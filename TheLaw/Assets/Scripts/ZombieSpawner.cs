using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{

    public Transform playersPostion;
    public GameObject myPrefabzombie;
    private GameObject[] zombieArmy;
    
    void Start()
    {
        generateSpawnPoints();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void generateSpawnPoints()
    {
        for (int i = 0; i < 10; i++)
        {
            var randomPos = (Vector3)(Random.insideUnitCircle * 5) + (Vector3)(Random.insideUnitCircle * 12); 
                randomPos += playersPostion.position;
        
                Instantiate(myPrefabzombie, randomPos, playersPostion.rotation);
        }
        
        
       
    }

}
