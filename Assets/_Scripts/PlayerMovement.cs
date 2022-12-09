using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // movement speed
    public float jumpForce = 10f; // force applied when jumping
    public float gravity = -9.81f; // gravitational acceleration

    CharacterController cc; // the CharacterController component

    void Start()
    {
        // get the CharacterController component on this GameObject
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        // get the input axes
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // calculate movement
        Vector3 move = transform.right * h + transform.forward * v;

        // apply movement to the CharacterController, including gravity
        cc.Move(move * moveSpeed * Time.deltaTime + Vector3.up * gravity * Time.deltaTime);

        // check if the player wants to jump
        if (Input.GetButtonDown("Jump") && cc.isGrounded)
        {
            // make the player jump by moving them upwards
            cc.Move(Vector3.up * jumpForce * Time.deltaTime);
            
        }
    }
}
