using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccess : MonoBehaviour {

	private int health = 100;

	public int score = 1000;

	string thingOne = "Thing One";

	void Box() {
		int newScore = 100;
		thingOne = "Fun";
		print (newScore);
		print (thingOne);	

		string thingTwo = "Thing Two";
		print (thingTwo);
	}

}
