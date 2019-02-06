using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMochi : MonoBehaviour
{
    // Key Codes 
    public KeyCode JumpKey;
    public KeyCode LeftKey;
    public KeyCode RightKey;
    public KeyCode DiveKey;

    private bool isGrounded;
    private Transform mochiTransform;
    private float groundSpeed = 5f;

    void Start()
    {
        mochiTransform = transform;
    }
    
    void Update()
    {
        Move();
    }


    void Move()
    {
        if (Input.GetKey(LeftKey))
        {
            
        }
        if (Input.GetKey(RightKey))
        {
            
        }
        if (Input.GetKey(DiveKey))
        {
            Dive();
        }
        else if (Input.GetKey(JumpKey))
        {
            
        }
        
    }

    void Dive()
    {
        // dive if in air
        // crouch if on ground
    }
}
