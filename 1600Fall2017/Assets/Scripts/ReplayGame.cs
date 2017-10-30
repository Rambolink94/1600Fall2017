using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReplayGame : MonoBehaviour {

	public Transform player;
	public Image uiBar;
	public GameObject gameOverUI;
	public static Vector3 startPosition;

	private float fillAmount;

	void Awake () 
	{
		startPosition = player.position;
		fillAmount = uiBar.fillAmount;
		gameOverUI.SetActive (false);
	}

	public void ClickReplay () 
	{
		CharacterControl.gameOver = false;
		player.position = startPosition;
		uiBar.fillAmount = fillAmount;
		gameOverUI.SetActive (false);
	}
}
