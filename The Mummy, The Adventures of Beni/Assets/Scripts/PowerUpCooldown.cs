using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCooldown : MonoBehaviour {

    public float powerUpCooldown = 10;

    void OnCollisionEnter2D()
    {
        StartCoroutine (Cooldown);
    }

    IEnumerator Cooldown() {
        
    }
}
