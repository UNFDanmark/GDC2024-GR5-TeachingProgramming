using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner_Script : MonoBehaviour
{
    public float SpawnCooldown = 10f;
    public float leftovercooldown;
    public GameObject enemyPrefab;

    public float xMin;
    public float xMax;
    public float zMin;
    public float zMax;
    
        
    // Start is called before the first frame update
    void Start()
    {
        leftovercooldown = SpawnCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        leftovercooldown = leftovercooldown - Time.deltaTime;
        if (leftovercooldown <= 0)
        {
            float xSpawn = Random.Range(xMin, xMax);
            float zSpawn = Random.Range(zMin, zMax);
            Vector3 spawnPoint = new Vector3(xSpawn, transform.position.y, zSpawn);
            Instantiate(enemyPrefab, spawnPoint, quaternion.identity);
            leftovercooldown = SpawnCooldown;
            
        }
        
        
    }
}
