using UnityEngine;
using UnityEngine.UI;

public class ReplayGame : MonoBehaviour {

	public Transform player;
	public Image hBar;
    public Image pBar;
    public Image sBar;
	public GameObject gameOverUI;
    public GameObject spReference;
	public static Vector3 startPosition;

	private float fillAmount;

	void Awake () 
	{
		startPosition = player.position;
        spReference.transform.position = player.position;
		fillAmount = hBar.fillAmount;
        fillAmount = pBar.fillAmount;
        fillAmount = sBar.fillAmount;
		gameOverUI.SetActive (false);
	}

	public void ClickReplay () 
	{
		PlayerController.gameOver = false;
		player.position = startPosition;
		hBar.fillAmount = fillAmount;
        pBar.fillAmount = fillAmount;
        sBar.fillAmount = fillAmount;
        gameOverUI.SetActive (false);
	}
}
