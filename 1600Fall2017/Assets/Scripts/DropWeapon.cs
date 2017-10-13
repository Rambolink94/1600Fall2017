using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropWeapon : MonoBehaviour {

	public Transform weapon;

	void Update(){
		if (Input.GetKeyDown (KeyCode.T)) {
			weapon.parent = null;
		}
	}
}
