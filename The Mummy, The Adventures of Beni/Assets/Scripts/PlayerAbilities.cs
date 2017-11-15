using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAbilities : MonoBehaviour {

	public Image pBar;
	public float powerUsage = 0.1f;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) 
		{
			pBar.fillAmount -= powerUsage;
		}
	}
}
