using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed = 50;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) {
			transform.position += Vector3.up * speed * Time.deltaTime;
			Debug.Log("Pressed 'W'");
		}
		if (Input.GetKey(KeyCode.A)) {
			transform.position += Vector3.left * speed * Time.deltaTime;
			Debug.Log("Pressed 'A'");
		}
		if (Input.GetKey(KeyCode.S)) {
			transform.position += Vector3.down * speed * Time.deltaTime;
			Debug.Log("Pressed 'S'");
		}
		if (Input.GetKey(KeyCode.D)) {
			transform.position += Vector3.right * speed * Time.deltaTime;
			Debug.Log("Pressed 'D'");
		}
	}
}
