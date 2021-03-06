using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Game
{
    public class MoveLeft : MonoBehaviour
    {
        [SerializeField] private float destroyPosition;
        [SerializeField] public float speed;

        void Awake()
        {
        }
  
        void Update()
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime,
                transform.position.y);

            if (transform.position.x <= destroyPosition)
            {
                Destroy(gameObject);
            }
        }
    }

}
