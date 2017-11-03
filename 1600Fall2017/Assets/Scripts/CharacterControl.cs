using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

	public CharacterController characterController;
	public static bool gameOver;
	public float speed = 10;
	public float gravity = 3f;
	public Vector3 moveVector3;
	public float jumpForce = 20;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		moveVector3.y -= gravity * Time.deltaTime;

		if (characterController.isGrounded && !gameOver) 
		{
			if (Input.GetKeyDown (KeyCode.Space)) 
			{
				moveVector3.y = jumpForce * Time.deltaTime;
			}
			moveVector3.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        }
		moveVector3.x = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
		characterController.Move (moveVector3);
	}
}
