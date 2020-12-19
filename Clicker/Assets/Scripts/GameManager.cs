using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    Game  game;
    public float pointsToAdd;
    void Start()
    {
        if (SceneManager.GetActiveScene().name != "MainMenu"&& instance == null)
        {
            Debug.Log("Change scene");
            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            if (instance == null)
            {
                Debug.Log("making an instance");
                DontDestroyOnLoad(this.gameObject);
                instance = this;
            }
            else
            {
                Debug.Log("already have an instance");
                Destroy(this);
            }
            Debug.Log("Making a game");
            game = new Game();
            pointsToAdd = 1;
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void CloseGame()
    {
        Debug.Log("Closing");
    }
    public void AddPoints()
    {
        game.AddPoints(pointsToAdd);
        UiManager.instance.UpdatePoints(game.points);
    }
    private void SubPoints()
    {
        game.SubPoints();
        UiManager.instance.UpdatePoints(game.points);
    }
    public void KillEnemy()
    {
        if (game.points > 0.5f && SpawnEnemies.instance.EaterPrefabs.Count>0)
        { 
            Debug.Log("Killing Enemy, cost one point");
            SpawnEnemies.instance.KillEnemy();
            SubPoints();
        }
    }
}
    