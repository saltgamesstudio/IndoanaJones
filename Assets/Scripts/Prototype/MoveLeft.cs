using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Prototype
{
    public class MoveLeft : MonoBehaviour
    {
        [SerializeField] private float destroyPosition;
        [SerializeField] private float speed;

        void Awake()
        {
        }
  
        void Update()
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime,
                transform.position.y);

            if(transform.position.x <= destroyPosition)
            {
                Destroy(gameObject);
            }
        }
    }

}
