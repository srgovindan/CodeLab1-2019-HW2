using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMochi : MonoBehaviour
{
    // Key Codes 
    public KeyCode JumpKey;
    public KeyCode LeftKey;
    public KeyCode RightKey;
    public KeyCode DiveKey;

    private Rigidbody2D mochiRB;
    private bool isGrounded;

    void Start()
    {
        mochiRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Collidable"))
        {
            isGrounded = true;
        }
    }

    void Move()
    {
        //
        if (Input.GetKey(LeftKey))
        {
            //
        }
        if (Input.GetKey(RightKey))
        {
            //
        }
        if (Input.GetKey(DiveKey))
        {
            Dive();
        }
        else if (Input.GetKey(JumpKey) && isGrounded)
        {
            isGrounded = false;
            // 
        }
       
    }

    void Dive()
    {
        // dive if in air
        // crouch if on ground
    }
}
