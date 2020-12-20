using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public static SpawnEnemies instance;
    public List<EaterPrefab> EaterPrefabs;
    public GameObject prefabtoSpawn;
    //For spawning
     public float startWait;
     public float spawnWait;

     public bool stop;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawner()
    {
        yield return  new WaitForSeconds(startWait);
        while(!stop)
        {
            Debug.Log("Spawn Enemy");
            Vector3 spawnedPos = new Vector3(1, 2,0);
            GameObject spawnedEater = Instantiate(prefabtoSpawn, spawnedPos + transform.TransformPoint (0,0,0), Quaternion.Inverse(gameObject.transform.rotation), UiManager.instance.transform);
            
            yield return new WaitForSeconds(spawnWait);
        }
    }
    public void KillEnemy()
    {
        EaterPrefab eaterPrefabForKill = EaterPrefabs[0];
         EaterPrefabs.Remove(eaterPrefabForKill);
        eaterPrefabForKill.Killed();
        if(EaterPrefabs.Count == 0)
        {
            GameManager.instance.pointsToAdd = 1f;
        }
    }
}
