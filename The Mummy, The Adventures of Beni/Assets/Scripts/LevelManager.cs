using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public static GameObject playerPrefab;
    public GameObject spReference;

	// Use this for initialization
	void Awake () {
        playerPrefab = GameObject.FindGameObjectWithTag("player");
        Instantiate(playerPrefab, spReference.transform.position, spReference.transform.rotation);
	}


}
