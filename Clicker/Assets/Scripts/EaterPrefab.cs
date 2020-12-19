using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EaterPrefab : MonoBehaviour
{
    public Eater eater;
    public static List<Eater> eaters = new List<Eater>();
    public void Start()
    {
        Created();
    }
    public void Created()
    {
        //this.transform.SetParent(UiManager.instance.transform,false);

        Debug.Log("Creat eater");
        if (eaters.Count == 0)
        {
            Debug.Log("created the first");
            eater = new Eater();
        }
        else
        {
            Debug.Log("created the clone");
            eater = (Eater)eaters[0].Clone();
        }
        Debug.Log("I am changing your points to " + eater.pointsToAdd);
        GameManager.instance.pointsToAdd = eater.pointsToAdd;
        eaters.Add(eater);
        SpawnEnemies.instance.EaterPrefabs.Add(this);
    }
    public void Killed()
    {
        Debug.Log("Killed eater");
        Destroy(this.gameObject);
    }


}
