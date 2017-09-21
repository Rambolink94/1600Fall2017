using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour {

    public int Health = 250;
    public int Armor = 100;
    public int Shield = 50;

    private bool isAlive = true;

	// Use this for initialization
	void Start () {
        while (Health > 0 && Armor > 0 && Shield > 0) {
            print("Player is Alive");
            return;
        }
        if (isAlive == false) {
            print("Player is Dead");
        }
	}

    public void decreaseHealth() {
        Health -= 10;
        print(Health);
    }

    public void decreaseArmor() {
        Armor -= 10;
        print(Armor);
    }

    public void decreaseShield() {
        Shield -= 10;
        print(Shield);
    }
}
