using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

	public void OnTriggerEnter2D () 
	{
		ReplayGame.startPosition = transform.position;
		print ("Hit Checkpoint");
	}
}
