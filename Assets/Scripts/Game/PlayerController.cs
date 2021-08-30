using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
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
            animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(jumpKey) && rb.velocity.y == 0)
            {
                rb.AddForce(Vector2.up * jumpForce);
                //animator.SetTrigger("startJump");
            }
            if(rb.velocity.y < 0 || rb.velocity.y > 0)
            {
                animator.SetBool("isJump", true);
            }

            if(rb.velocity.y == 0)
            {
                animator.SetBool("isJump",false);
            }
        }

    }

}
