using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class ItemSpawner : MonoBehaviour
    {
        private GameManager manager;

        [SerializeField] private GameObject[] obstacles;
        [Space]
        [SerializeField] private float spawnTime;
        [SerializeField] private float nextSpawn;
        [SerializeField] private float minSpawnTime;
        [SerializeField] private float maxSpawnTime;
        [Space]
        [SerializeField] public float obstacleSpeed;
        [SerializeField] private float spawnPosX;

        void Awake()
        {
            manager = GameObject.FindObjectOfType<GameManager>();
            if (manager == null)
            {
                Debug.LogError("Game manager not instantiated!");
            }
        }

        void Update()
        {
            if(Time.time > nextSpawn)
            {
                nextSpawn = Time.time + Random.Range(minSpawnTime, maxSpawnTime);
                int randomIndex = Random.Range(0, obstacles.Length);
                var randomPosition = new Vector3(0,0,0);

                switch (randomIndex)
                {
                    case 0: // case barrel
                        {
                            randomPosition = new Vector3(spawnPosX, -2f,0);
                            break;
                        }
                    case 1: //case arrow
                        {
                            randomPosition = new Vector3(spawnPosX, Random.Range(-2f,2), 0);
                            break;
                        }
                    case 2: //case gem
                        {
                            randomPosition = new Vector3(spawnPosX, Random.Range(-2f, 2), 0);
                            break;
                        }

                    default:
                        break;
                }
                var obstacleObject = Instantiate(obstacles[randomIndex], randomPosition, Quaternion.identity, transform);
                var obstacleMover = obstacleObject.GetComponent<MoveLeft>();
                obstacleMover.speed = obstacleSpeed;
            }
            
        }
    }
}
