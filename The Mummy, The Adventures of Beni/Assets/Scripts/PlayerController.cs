using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public CharacterController characterController;

    public float speed = 10;
    public float gravity = 3f;
    public float jumpForce = 20;

    public Vector3 movement;

    void Update()
    {
        movement.y -= gravity * Time.deltaTime;

        if (characterController.isGrounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                movement.y += jumpForce * Time.deltaTime;
            }
            movement.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        }
        movement.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        characterController.Move(movement);
    }
}
