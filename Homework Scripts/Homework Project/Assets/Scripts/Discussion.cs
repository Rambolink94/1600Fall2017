using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Discussion : MonoBehaviour {

    public int intelligence = 5;
    public int persuasion = 5;

    public void Intelligence() {
        switch (intelligence) {         //This Switch statement (On button click) checks to see what the public intelligence variable is, then prints a message based on that.
            case 5:
                print("Hello, my lord. It is a pleasure to be in your presents.");
                return;
            case 4:
                print("Hello, my lord. It's nice to see you again.");
                return;
            case 3:
                print("My Lord.");
                return;
            case 2:
                print("Me Lord.");
                return;
            case 1:
                print("Something needs doing?");
                return;
            default:
                print("Intelligence is out of range.");
                return;
        }
    }
    public void Persuasion() {
            switch (persuasion) {           //Like the previous switch statement, this switch statement checks the persuasion var, and prints a message accordingly.
                case 5:
                    print("My Lord, I am afraid you have no claim to this title, and according to this document(A fabricated claim)...I do.");
                    return;
                case 4:
                    print("My Lord, your claim to this title is weak...someone may rise to take it.");
                    return;
                case 3:
                    print("My Lord, I think that you might lose this claim, because it lacks strength. I could even take the seat.");
                    return;
                case 2:
                    print("My Lord, your title is weak. Can I have it?");
                    return;
                case 1:
                    print("Your titles like weak, or whatever. Could I like, you know, maybe have it....or whatever?");
                    return;
                default:
                    print("Persuasion is out of range.");
                    return;
            }
        }
    }
