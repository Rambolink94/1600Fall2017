using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	// Use this for initialization
	public void Start () {
		Die();
	}

	void Die (){
		print (this.name + " Died");
	}
}
