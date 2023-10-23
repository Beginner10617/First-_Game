using UnityEngine;
using System;



public class Simple2DMovement : MonoBehaviour
{  
    private Rigidbody2D rb;
//    public float moveSpeed = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalInput = 0f;
        float verticalInput = 0f;
        
        if (Input.GetKey(KeyCode.D))
        {
            horizontalInput = 1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = -1f;
        }

        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized * reward.moveSpeed;

        rb.velocity = movement;
    }
}