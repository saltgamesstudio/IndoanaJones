using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game { 
    public class MoveLeftBackground : MonoBehaviour
    {
        [SerializeField] private float minPosition;
        [SerializeField] private float maxPosition;
        [SerializeField] public float speed;

        void Awake()
        {
        }

        void Update()
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime,
                transform.position.y);

            if (transform.position.x <= minPosition)
            {
                transform.position = new Vector2(maxPosition, transform.position.y);
            }
        }
    }
}
