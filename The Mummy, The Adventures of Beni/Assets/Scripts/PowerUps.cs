using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PowerUps : MonoBehaviour {

	public GameObject gameOverUI;
	public Image hBar;
	public Image pBar;
	public Text endGameText;
	public Text coinNum;
    AudioSource powerUpSounds;
    public AudioClip[] hurtSoundsClips;
    private AudioClip selectedSoundClip;
    SpriteRenderer colorAlpha;
	public int totalCoinValue;
	public int coinValue = 10;
	public float healthPowerLevel = 0.1f;
	public float powerPowerLevel = 0.1f;
	public float amountToAdd = 0.01f;
    public GameObject spReference;

    void Start()
    {
        powerUpSounds = GetComponent<AudioSource>();
        colorAlpha = GetComponent<SpriteRenderer>();
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
        powerUpSounds.Play();
        colorAlpha.color = new Color(1, 1, 1, 0);
        while (powerUpSounds.isPlaying == true) {
            yield return new WaitUntil(() => powerUpSounds.isPlaying == false); 
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
        powerUpSounds.Play();
        colorAlpha.color = new Color(1, 1, 1, 0);
        while (powerUpSounds.isPlaying == true)
        {
            yield return new WaitUntil(() => powerUpSounds.isPlaying == false);
            // Interesting new code I learned about with kinda weird syntax. Allows a function to wait until a bool parameter is met.
        }
        Destroy(gameObject);
    }

	// Decreasing Health
	IEnumerator PowerDownBar () {
        PlayHurtSounds();
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
        powerUpSounds.Play();
        colorAlpha.color = new Color(1, 1, 1, 0);
        while (powerUpSounds.isPlaying == true)
        {
            yield return new WaitUntil(() => powerUpSounds.isPlaying == false);
            // Interesting new code I learned about with kinda weird syntax. Allows a function to wait until a bool parameter is met.
        }
        Destroy(gameObject);
    }

    // Checkpoint
    void CheckPoint() {
        powerUpSounds.Play();
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

    void PlayHurtSounds() {
        int index = Random.Range(0, hurtSoundsClips.Length);
        selectedSoundClip = hurtSoundsClips[index];
        powerUpSounds.clip = selectedSoundClip;
        foreach (AudioClip audioclip in hurtSoundsClips)
        {
            Debug.Log("Currently playing " + selectedSoundClip.name + " from hurtSoundsClips Array.");
        }
        powerUpSounds.Play();
    }
}
