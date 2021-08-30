using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype
{
    public class ItemSpawner : MonoBehaviour
    {
        [SerializeField] private Transform spawnPosition;
        [SerializeField] private GameObject[] obstacles;
        [Space]
        [SerializeField] private float spawnTime;
        [SerializeField] private float nextSpawn;
        [SerializeField] private float minSpawnTime;
        [SerializeField] private float maxSpawnTime;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if(Time.time > nextSpawn)
            {
                nextSpawn = Time.time + Random.Range(minSpawnTime, maxSpawnTime);
                int randomIndex = Random.Range(0, obstacles.Length);
                Instantiate(obstacles[randomIndex], spawnPosition.position, Quaternion.identity);
            }
        }
    }
}
