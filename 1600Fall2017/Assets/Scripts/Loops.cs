using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

	public bool canPlay = true;

	void Start () {
		StartCoroutine (PlayGame ());
	}

	IEnumerator PlayGame () {
		while (canPlay) {
			print ("Play");		
			yield return new WaitForSeconds (0.1f);
		}
		print ("Game Over");	
	}
}
