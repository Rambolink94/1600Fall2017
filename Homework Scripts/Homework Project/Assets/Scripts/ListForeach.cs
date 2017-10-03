using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListForeach : MonoBehaviour {

    //This list picks up powerups and stores them.
    public List<GameObject> powerup;

    void OnTriggerEnter(Collider _powerup)
    {
        //This is where the atual 'picking up' happens.
        powerup.Add(_powerup.gameObject);

        //This simply tells which powerup was picked up
        foreach (GameObject item in powerup) {
            print(_powerup.name);
        }

        //I would impliment actually adding the powerup amount to a visual HUD,
        //but I feel foreach loops aren't the best way to do that.
    }
}
