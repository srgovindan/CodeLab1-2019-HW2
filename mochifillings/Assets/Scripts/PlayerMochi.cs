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
    private float groundVelocity = 5f;
    private float jumpVelocity = 10f;
    private float diveVelocity = 8f;

    void Start()
    {
        mochiRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector2 newMochiVelocity = new Vector2();
        if (Input.GetKey(LeftKey))
        {
            newMochiVelocity.x += -groundVelocity;
        }
        if (Input.GetKey(RightKey))
        {
            newMochiVelocity.x += groundVelocity;
        }
        if (Input.GetKey(DiveKey))
        {
            if (!isGrounded)
            {
                newMochiVelocity.y = +-diveVelocity;
            }
        }
        else if (Input.GetKey(JumpKey) && isGrounded)
        {
            isGrounded = false;
            newMochiVelocity.y += jumpVelocity;
        }
        mochiRB.velocity = newMochiVelocity;
        if (mochiRB.velocity == new Vector2(0,0))
        {
            isGrounded = true;
        }
    }
}
