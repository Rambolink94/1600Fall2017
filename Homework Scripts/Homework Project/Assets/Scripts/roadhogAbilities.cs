using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadhogAbilities : MonoBehaviour {

    // I designed the moves that Roadhog from Overwatch uses. I think later on, this would actually
    // work very well for a bases of the character, and other characters.
    void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {         // Mouse Button 1 = Primary Fire
            ScrapGunPrimary();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1)) {         // Mouse Button 2 = Secondary Fire
            ScrapGunSecondary();
        }
        if (Input.GetKeyDown(KeyCode.Mouse3)) {         // Mouse Button 4 = Melee Attack
            Melee();
        }
        if (Input.GetKeyDown(KeyCode.LeftShift)) {      // Keyboard Button LeftShift = Chain Hook
            ChainHook();
        }
        if (Input.GetKeyDown(KeyCode.E)) {              // Keyboard Button E = Take A Breather
            TakeABreather();
        }
        if (Input.GetKeyDown(KeyCode.Q)) {              // Keyboard Button Q = Whole Hog
            WholeHog();
        }
    }
    
    // This is Roadhogs primary fire, which spreads like a shotgun.
    void ScrapGunPrimary() {
        Debug.Log("Primary Fire");
    }

    // Roadhogs secondary fire. Starts as a scrap ball, then spreads.
    void ScrapGunSecondary() {
        Debug.Log("Secondary Fire");
    }

    // Roadhogs melee.
    void Melee() {
        Debug.Log("Melee");
    }

    // Roadhogs chain grapple ability.
    void ChainHook() {
        Debug.Log("Grapple");
    }

    // Roadhogs healling ability.
    void TakeABreather() {
        Debug.Log("Heal");
    }

    // Roadhogs Whole Hog Ultimate.
    void WholeHog() {
        Debug.Log("Whole Hog");
    }
}
