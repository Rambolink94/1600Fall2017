using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class runGame : MonoBehaviour {

	public Toggle toggle;
	
	// Update is called once per frame
	void Update () {
		if (toggle.isOn) {
			print ("Play Game");
		} else {
			print ("Can't Play");
		}
	}
}
