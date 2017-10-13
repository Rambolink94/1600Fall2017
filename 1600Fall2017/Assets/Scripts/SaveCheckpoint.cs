using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveCheckpoint : MonoBehaviour {

	public Transform player;

	Vector3 checkPoint;
	string[] playerPrefsTitles = { "Checkpointx", "Checkpointy", "Checkpointz" };

	void OnTriggerEnter() {

		checkPoint = transform.position;

		for (int i = 0; i < playerPrefsTitles.Length; i++) 
		{
			PlayerPrefs.SetFloat (playerPrefsTitles[i], checkPoint[i]);
			print (PlayerPrefs.GetFloat (playerPrefsTitles[i]));
		}
	}

	void Start() {
		for (int i = 0; i < playerPrefsTitles.Length; i++) 
		{
			checkPoint[i] = PlayerPrefs.GetFloat (playerPrefsTitles[i]);
		}
		player.position = checkPoint;
	}
}
