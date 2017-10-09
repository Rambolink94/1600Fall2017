using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathFunctions : MonoBehaviour {

	public int myScore;
	public int health;
	public int ammo;

	public string myPassword = "old greg";

	void Start () {
		myScore = ReturnNum (health, ammo);
		myPassword = ReturnPassword ("old greg");
	}

	int ReturnNum (int _num, int _num2) {
		return _num + _num2;
	}

	string ReturnPassword (string _login) {
		if (_login == "old greg") {
			return "Correct";
		} else {
			return "Incorrect";
		}

		return "Password";
	}
}
