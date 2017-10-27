using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBar : MonoBehaviour {

	public GameObject gameOverUI;
	public Image bar;
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

	// Increasing Health
	IEnumerator PowerUpBar () {
		float tempAmount = bar.fillAmount + powerLevel;
		if (tempAmount > 1) 
		{
			tempAmount = 1;
		}
		while(bar.fillAmount < tempAmount) 
		{
			bar.fillAmount += amountToAdd;
			yield return new WaitForSeconds (amountToAdd);
		}
	}

	// Decreasing Health
	IEnumerator PowerDownBar () {
		float tempAmount = bar.fillAmount - powerLevel;
		if (tempAmount < 0) 
		{
			tempAmount = 0;
		}
		while(bar.fillAmount > tempAmount) 
		{
			bar.fillAmount -= amountToAdd;
			yield return new WaitForSeconds (amountToAdd);
		}

		if (bar.fillAmount == 0) {
			gameOverUI.SetActive (true);
			CharacterControl.gameOver = true;
		}
	}
}
