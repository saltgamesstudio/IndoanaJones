using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype
{
    public class PlayerController : MonoBehaviour
    {
        private Animator animator;
        private Rigidbody2D rb;

        [SerializeField] private float jumpForce;
        [SerializeField] private KeyCode jumpKey;
        // Start is called before the first frame update
        void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(jumpKey) && rb.velocity.y == 0)
            {
                rb.AddForce(Vector2.up * jumpForce);
            }
        }

       

    }

}
