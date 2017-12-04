using UnityEngine;
using UnityEngine.UI;

public class ReplayGame : MonoBehaviour {

	public Transform player;
	public Image hBar;
    public Image pBar;
    public Image sBar;
	public GameObject gameOverUI;
    public GameObject spReference;
	public static Vector3 oldPosition;

	private float fillAmount;

	void Start () 
	{
        oldPosition = spReference.transform.position;
		fillAmount = hBar.fillAmount;
        fillAmount = pBar.fillAmount;
        fillAmount = sBar.fillAmount;
		gameOverUI.SetActive (false);
	}

	public void ClickReplay () 
	{
		PlayerController.gameOver = false;
        oldPosition = spReference.transform.position;
        player.position = oldPosition;
		hBar.fillAmount = fillAmount;
        pBar.fillAmount = fillAmount;
        sBar.fillAmount = fillAmount;
        gameOverUI.SetActive (false);
	}
}
