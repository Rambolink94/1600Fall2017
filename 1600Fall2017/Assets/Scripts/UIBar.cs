using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBar : MonoBehaviour {

	public Image bar;
	public float barTime = 0.1f;

	// Use this for initialization
	void Start () {
		StartCoroutine (UpdateBar ());
	}
	
	IEnumerator UpdateBar () {
		while(bar.fillAmount < 1) 
		{
			bar.fillAmount += barTime;
			yield return new WaitForSeconds (barTime);
		}
	}
}
