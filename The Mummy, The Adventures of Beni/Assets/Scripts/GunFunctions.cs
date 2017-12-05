using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFunctions : MonoBehaviour {

    public float fireRate = 0;
    public float gunDamage = 10;
    public float gunRange = 100;
    public float effectSpawnTime;
    public float effectSpawnRate = 10;
    public LayerMask thingsToHit;
    public Transform bulletTrail;

    public bool rangeTest = false;

    private float timeToFire = 0;
    private Transform gunEnd;

	void Awake () {
        gunEnd = transform.Find("GunEnd");
        if (gunEnd == null)
        {
            Debug.LogError("There is no gun end that is a Child of the gun.");
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (rangeTest == false)
        {
            // Semiauto fire rate
            if (fireRate == 0)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    Shoot();
                }
            }
            // Automatic fire rate
            else
            {
                if (Input.GetButton("Fire1") && Time.time > timeToFire)
                {
                    timeToFire = Time.time + 1 / fireRate;      // dividing 1 by fireRate makes it a rate, rather than a delay. It works better, and makes more sense.
                    Shoot();
                }
            }
        }
        else
        {
            Shoot();
        }
	}

    void Shoot() {
        // Creates a Vector2 (x,y). The mouse position on both the x and y positions are stored in the x and y points in the Vector 2.
        // What this does is simply creates and stores a point at the mouse position each time we shoot.
        Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        Vector2 gunEndPosition = new Vector2(gunEnd.position.x, gunEnd.position.y);     //Finds and stores the location of the guns end in a Vector2.
        RaycastHit2D hit = Physics2D.Raycast(gunEndPosition, gunEndPosition - mousePosition, gunRange, thingsToHit);
        if (Time.time >= effectSpawnTime)
        {
            ShotEffect();
            effectSpawnTime = Time.time + 1 / effectSpawnRate;      //similar to what I did for gun fire rate, I created a rate at which effects spawn.
        }
        Debug.DrawLine (gunEndPosition, (gunEndPosition - mousePosition) * gunRange, Color.red);
        if (hit.collider != null)
        {
            Debug.DrawLine(gunEndPosition, hit.point, Color.yellow);
            Debug.Log(hit.collider.name + " was hit for: " + gunDamage + "damage.");
        }
    }

    // Creates a bullet trail from the gun.
    void ShotEffect() {
        Instantiate(bulletTrail, gunEnd.position, gunEnd.rotation);
    }
}
