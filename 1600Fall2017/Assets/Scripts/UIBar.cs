using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIBar : MonoBehaviour {

	public GameObject gameOverUI;
	public Image bar;
	public Text checkpointText;
	public Text endGameText;
	public Text coinNum;
	public int totalCoinValue;
	public int coinValue = 10;
	public float powerLevel = 0.1f;
	public float amountToAdd = 0.01f;

	public enum PowerUpType
	{
		PowerUP,
		PowerDown,
		CollectCoin,
		Win,
		Checkpoint
	}

	public PowerUpType powerUp;

	void OnTriggerEnter () {
		switch (powerUp)
		{
		case PowerUpType.PowerUP:
			StartCoroutine(PowerUpBar());
			break;
		case PowerUpType.PowerDown:
			StartCoroutine (PowerDownBar());
			break;
		case PowerUpType.CollectCoin:
			StartCoroutine (CollectCoin());
			break;
		case PowerUpType.Win:
			EndGame ("You Win!");
			break;
		case PowerUpType.Checkpoint:
			Checkpoint ("Checkpoint!");
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
			EndGame ("Game Over");
		}
	}

	// Ends the Game
	void EndGame (string _text) {
		endGameText.text = _text;
		gameOverUI.SetActive (true);
		CharacterControl.gameOver = true;
	}

	// Creates a Checkpoint
	void Checkpoint (string _text) {
		checkpointText.text = _text;
		ReplayGame.startPosition = transform.position;
		Debug.Log ("Code got here");
	}
}
