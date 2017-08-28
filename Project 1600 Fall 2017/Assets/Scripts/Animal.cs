using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Die();
	}

	void Die (){
		print (this.name + " Died");
	}
}
