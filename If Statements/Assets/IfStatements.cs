using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour {

	public float health;
	public float damage;
	private int sun = 1;
	private int yellow = 3;

	void Start () {									
		if (sun >= yellow){								//This if statement compares the values of sun and yellow, which are 1 and 3. It asks, is 1 greater than or equal to 3?
			print ("The yellow one's the sun!");		//Since the answer is no, the console doesn't print, instead it runs the else statement.
		} else {										//The else statement than Debug.Logs because it was the option for when the if isn't true.
			Debug.Log("We aren't on earth");
		}
	}
	void Update () {									//This if statement first checks if health is greater than 0, and if so, decrements a set damage each frame.
		if (health > 0f){								//Damage and Health can be changed in the inspector, because they are publicly exposed.
			health -= damage;
			Debug.Log(health);
		} else {
			//print("You have died");					//Once your health becomes less than 0, "You have died" is printed to the console (if it was active).
		}
		if (Input.GetKeyDown(KeyCode.W)){				//This if statement asks if the 'W' Input key is down
			transform.position = new Vector3 (0,1,0);	//If it is, than the position of the object moves up 1 in the y axis
			Debug.Log("Pressing W");					//It is also logged to the console
		}
		//This is how if statements work
		//if (what you are asking for, and wether it is true) {
		//		the output for if 'if' is true
		//} else {
		//		the output for if 'if' wasn't true
		//} if else {
		//		the output for if 'if' was true, but else still needs to run.
		//}

	}	//I have more IfStatements, that I will submit later. For some reason only some of my Github folders were transported.
}
