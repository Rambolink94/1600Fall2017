using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	// Use this for initialization
	public virtual void Start () {
		Die();
		Eat();
		Sleep();
	}

	void Die (){
		print (this.name + " Dies");
	}

	void Eat (){
		print (this.name + " Eats");
	}

	void Sleep (){
		print (this.name + " Sleeps");
	}
}
