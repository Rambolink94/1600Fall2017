using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailMovement : MonoBehaviour {

    public float movementSpeed = 200;

	// Update is called once per frame
	void Update () {
        if (PlayerController.facingRight == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);    //Moves bullet trail. Had to inverse to make work.
        }
        else
        {
            transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);    //Moves bullet trail
            Destroy(gameObject, 1);    //Destroys bullet trail after 1 second.
        }
	}
}
