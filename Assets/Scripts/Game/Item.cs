using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Item : MonoBehaviour
    {
        public enum ItemType { Obstacle, Gem }
        private GameManager manager;
        [SerializeField] private ItemType type;
        private void Awake()
        {
            manager = GameObject.FindObjectOfType<GameManager>();
            if(manager == null)
            {
                Debug.LogError("Game manager not instantiated!");
            }
        }
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.name.Equals("Player"))
            {
                if(type == ItemType.Gem)
                {
                    manager.AddGem();
                    Destroy(gameObject);
                } else
                {
                    manager.GameOver();
                }
            }
        }
    }
}
