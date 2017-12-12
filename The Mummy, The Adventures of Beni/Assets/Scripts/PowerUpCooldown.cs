using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCooldown : MonoBehaviour {

    public float powerUpCooldown = 10;

    void OnCollisionEnter2D()
    {
        Debug.Log("Got here");
        StartCoroutine (Cooldown());
    }

    IEnumerator Cooldown() {
        this.gameObject.SetActive(false);
        yield return new WaitForSeconds(powerUpCooldown);
        this.gameObject.SetActive(true);
    }
}
