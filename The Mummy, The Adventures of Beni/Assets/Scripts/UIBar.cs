﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIBar : MonoBehaviour {

	public GameObject gameOverUI;
	public Image hBar;
	public Image pBar;
	public Text endGameText;
	public Text coinNum;
	public int totalCoinValue;
	public int coinValue = 10;
	public float healthPowerLevel = 0.1f;
	public float powerPowerLevel = 0.1f;
	public float amountToAdd = 0.01f;

	public enum PowerUpType
	{
		PowerUP,
		PowerDown,
		PowerPower,
		CollectCoin,
		Win,
        Checkpoint
	}

	public PowerUpType powerUp;

	void OnTriggerEnter2D () {
		switch (powerUp)
		{
		case PowerUpType.PowerUP:
			StartCoroutine(PowerUpBar());
			break;
		case PowerUpType.PowerDown:
			StartCoroutine (PowerDownBar());
			break;
		case PowerUpType.PowerPower:
			StartCoroutine (PowerPowerBar());
			break;
		case PowerUpType.CollectCoin:
			StartCoroutine (CollectCoin());
			break;
		case PowerUpType.Win:
			EndGame ("You Win!");
			break;
            case PowerUpType.Checkpoint:
                Checkpoint();
                break;

        }
	}

	// Collects Coins
	IEnumerator CollectCoin () {
		totalCoinValue = int.Parse(coinNum.text);
		int tempAmount = totalCoinValue + coinValue;
		while (totalCoinValue <= tempAmount) 
		{
			coinNum.text = (totalCoinValue++).ToString();
			yield return new WaitForFixedUpdate();	
		}
	}

	// Increasing Health
	IEnumerator PowerUpBar () {
		float tempAmount = hBar.fillAmount + healthPowerLevel;
		if (tempAmount > 1) 
		{
			tempAmount = 1;
		}
		while(hBar.fillAmount < tempAmount) 
		{
			hBar.fillAmount += amountToAdd;
			yield return new WaitForSeconds (amountToAdd);
		}
	}

	// Decreasing Health
	IEnumerator PowerDownBar () {
		float tempAmount = hBar.fillAmount - healthPowerLevel;
		if (tempAmount < 0) 
		{
			tempAmount = 0;
		}
		while(hBar.fillAmount > tempAmount) 
		{
            Debug.Log("Something is happening");
			hBar.fillAmount -= amountToAdd;
			yield return new WaitForSeconds (amountToAdd);
		}

		if (hBar.fillAmount == 0) {
			EndGame ("Game Over");
		}
	}

	IEnumerator PowerPowerBar () {
		Debug.Log ("You reached this code.");
		float tempAmount = pBar.fillAmount + powerPowerLevel;
		if (tempAmount > 1) 
		{
			tempAmount = 1;
		}
		while(pBar.fillAmount < tempAmount) 
		{
			pBar.fillAmount += amountToAdd;
			yield return new WaitForSeconds (amountToAdd);
		}
	}

	// Ends the Game
	void EndGame (string _text) {
		endGameText.text = _text;
		gameOverUI.SetActive (true);
		PlayerController.gameOver = true;
	}

    void Checkpoint() {

    }
}
