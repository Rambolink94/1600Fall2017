using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script would be an damage dealing script that could be implimented into a game (with a bit of
// modifications and tweaking). It uses both the for loop, and access modifiers.

public class forLoops : MonoBehaviour {

    //These public integers represent different types of attacks. They each deal their initial damage,
    //and then additional damage after the fact.
    public int normalAttack = 10;
    public int heavyAttack = 20;
    public int hammerSmash = 50;
    public int whirlwind = 20;
    
    //These bools represent cooldowns of the hammer smash and whirlwind attacks. If these are false,
    //then the attacks cannot be used.
    public bool smashAttackCooldown = true;
    public bool whirlAttackCooldown = false;

    //These bools are unused, but could be an additional effect that has a chance to happen.
    private bool heavyAttackStun = false;
    private bool hammerSmashParalize = false;
    private bool whirlhitmulti = false;

    void Start() {
        //If the whirl attack cooldown is true, then the whirlwind attack is used. It hits for 20,
        //then decrements its hitpoints by 1 each following attack.
        if (whirlAttackCooldown == true)
        {
            for (int i = 20; i > 0; i--)
            {
                print("Enemy hit for " + i + " using Whirlwind");
            }
        }
        //If the cooldown isn't over, than the system logs that it isn't.
        else {
            Debug.Log("Whirlwind still in cooldown");
        }
        //Just like the above whirlwind attack, the smash deals damage, then decrements to less
        //damage until it no longer is dealing damage.
        if (smashAttackCooldown == true)
        {
            for (int i = 50; i > 0; i = i - 10)
            {
                print("Enemy hit for " + i + " using Hammer Smash!");
            }
        }
        //Logs to the console if it isn't done with cooldown.
        else {
            Debug.Log("Smash Attack still in cooldown");
        }
        //These normal attacks hit for 10, then set the enemy on fire, dealing 0.5 damage until 0.
        for (float i = 10; i > 0; i = i - 0.5f) {
            print("Enemy hit for " + i + " using a normal attack, causing slow fire damage");
        }
        //Heavy attacks hit for 20, then deal poison damage for 1 until 0.
        for (float i = 20; i > 0; i--) {
            print("Enemy hit for " + i + " using a heavy attack, causing fast poison damage");
        }
    }
}
