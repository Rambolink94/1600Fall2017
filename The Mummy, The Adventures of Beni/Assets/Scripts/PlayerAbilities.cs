using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAbilities : MonoBehaviour {

	public Image pBar;
    public Image sBar;
	public float powerUsage = 0.1f;
    public float specialUsage = 1;
    public ParticleSystem healthParticles;

    void Start()
    {
        var em = healthParticles.emission;
        em.enabled = false;
    }

    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown (KeyCode.E)) 
		{
            pBar.fillAmount -= powerUsage;
            var em = healthParticles.emission;
            em.enabled = true;
            Debug.Log("Das code hath been here");
		}
    }
}
