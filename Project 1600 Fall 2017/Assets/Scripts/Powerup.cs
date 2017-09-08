using UnityEngine;

public class Powerup : MonoBehaviour {
    private void OnTriggerEnter()
    {
        gameObject.SetActive(false); 
    }
}
