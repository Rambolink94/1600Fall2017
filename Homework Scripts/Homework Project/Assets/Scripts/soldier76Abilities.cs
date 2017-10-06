using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldier76Abilities : MonoBehaviour
{
    // This float would go in the Soldier 76 Stats script, but I'll put it here for now.
    public float health = 200f;
    public bool regenHealth;
    // Just like Roadhogs script, this is an ability page that I think could be implimented, after
    // some modification of course, to an actual Overwatch style game (any other game too).
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {         // Mouse Button 1 = Primary Fire
            PulseRiflePrimary();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {         // Mouse Button 2 = Secondary Fire
            HelixSecondary();
        }
        if (Input.GetKeyDown(KeyCode.Mouse3))
        {         // Mouse Button 4 = Melee Attack
            Melee();
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {      // Keyboard Button LeftShift = Chain Hook
            Sprint();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {              // Keyboard Button E = Take A Breather
            BioticField();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {              // Keyboard Button Q = Whole Hog
            TacticalVisor();
        }
    }

    // This is Soldier 76's primary fire, which shoots quickly and acurately.
    void PulseRiflePrimary()
    {
        Debug.Log("Primary Fire");
    }

    // Soldier 76's secondary fire. Shoots out rockets that deal massive damage.
    void HelixSecondary()
    {
        Debug.Log("Secondary Fire");
    }

    // Soldier's melee.
    void Melee()
    {
        Debug.Log("Melee");
    }

    // Soldier's Sprint ability.
    void Sprint()
    {
        Debug.Log("Sprint");
    }

    // Soldier's healling ability.
    void BioticField()
    {
        if (health < 200f && regenHealth == false) {
            regenHealth = true;
            StartCoroutine("CooldownHealth");
        }
        Debug.Log("Put down Healer");
    }

    // Healer Ability Cooldown
    IEnumerator CooldownHealth()
        {
            health += 40.8f;
            yield return new WaitForSeconds(15);
            regenHealth = false;
        }
    // Soldier's Tactical Visor Ultimate.
    void TacticalVisor()
    {
        Debug.Log("Tactical Visor Ult");
    }

    // Example Damage Reciever
    // Set Up to a button
    public void TakeDamage()
    {
        health -= 50f;
    }
}
