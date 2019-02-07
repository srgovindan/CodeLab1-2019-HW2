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

    private Vector3 newMochiPos;
    private bool isGrounded;
    private float groundSpeed = .3f;
    private float jumpSpeed = .08f;
    private float gravity = -0.07f;
        
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
        Vector2 newMochiSpeed = new Vector3();
        if (Input.GetKey(LeftKey))
        {
            newMochiSpeed.x += -groundSpeed;
        }
        if (Input.GetKey(RightKey))
        {
            newMochiSpeed.x += groundSpeed;
        }
        if (Input.GetKey(DiveKey))
        {
            Dive();
        }
        else if (Input.GetKey(JumpKey) && isGrounded)
        {
            isGrounded = false;
            newMochiSpeed.y += jumpSpeed;
        }
        // calculate new mochi position
        newMochiPos.x = transform.position.x + newMochiSpeed.x;
        newMochiPos.y = transform.position.y + newMochiSpeed.y;
        // set new mochi position 
        transform.position = newMochiPos;
    }

    void Dive()
    {
        // dive if in air
        // crouch if on ground
    }
}
