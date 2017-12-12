using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PowerUps : MonoBehaviour {

	public GameObject gameOverUI;
	public Image hBar;
	public Image pBar;
	public Text endGameText;
	public Text coinNum;
    AudioSource coinCollectSound;
	public int totalCoinValue;
	public int coinValue = 10;
	public float healthPowerLevel = 0.1f;
	public float powerPowerLevel = 0.1f;
	public float amountToAdd = 0.01f;
    public GameObject spReference;

    void Start()
    {
        coinCollectSound = GetComponent<AudioSource>();
    }

    public enum PowerUpType
	{
		PowerUP,
		PowerDown,
		PowerPower,
		CollectCoin,
        CheckPoint,
		Win
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
        case PowerUpType.CheckPoint:
            CheckPoint();
            break;
		case PowerUpType.Win:
			EndGame ("You Win!");
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
        coinCollectSound.Play();
        while (coinCollectSound.isPlaying == true) {
            yield return new WaitUntil(() => coinCollectSound.isPlaying == false); 
            // Interesting new code I learned about with kinda weird syntax. Allows a function to wait until a bool parameter is met.
        }
        Destroy(gameObject);
    }

	// Increasing Health
	public IEnumerator PowerUpBar () {
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
        Destroy(gameObject);
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
			hBar.fillAmount -= amountToAdd;
			yield return new WaitForSeconds (amountToAdd);
		}

		if (hBar.fillAmount == 0) {
			EndGame ("Game Over");
		}

    }

    // Decreases Power
	IEnumerator PowerPowerBar () {
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
        Destroy(gameObject);
    }

    // Checkpoint
    void CheckPoint() {
        Debug.Log("Got here");
        spReference.transform.position = gameObject.transform.position;
    }

	// Ends the Game
	void EndGame (string _text) {
		endGameText.text = _text;
		gameOverUI.SetActive (true);
        Debug.Log("Got here");
		PlayerController.gameOver = true;
	}
}
