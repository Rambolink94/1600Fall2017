using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBar : MonoBehaviour {

	public Image bar;
	public float barTime = 0.1f;
	public float powerLevel = 0.1f;
	public float amountToAdd = 0.01f;

	public enum PowerUpType
	{
		PowerUP,
		PowerDown
	}

	public PowerUpType powerUp;

	// Use this for initialization
	void OnTriggerEnter () {
		switch (powerUp)
		{
		case PowerUpType.PowerUP:
			StartCoroutine(PowerUpBar());
			break;
		case PowerUpType.PowerDown:
			StartCoroutine (PowerDownBar());
			break;
		}
	}
	
	IEnumerator PowerUpBar () {
		while(bar.fillAmount < 1) 
		{
			bar.fillAmount += amountToAdd;
			yield return new WaitForSeconds (barTime);
		}
	}

	IEnumerator PowerDownBar () {
		float tempAmount = powerLevel;
		float fillAmount = bar.fillAmount;
		while (powerLevel > 0) 
		{
			fillAmount = tempAmount - amountToAdd;
			bar.fillAmount = fillAmount;

			yield return new WaitForSeconds (barTime);
		}
	}
}
