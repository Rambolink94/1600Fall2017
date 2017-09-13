using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElseStatements : MonoBehaviour {

	public Text text;
	public Toggle toggle, toggle2, toggle3, toggle4;

	public float Age;
	public float num1;

	void Start () {

		if (num1 < 100) {							//Checks to see if num is less than 100
			print("Number less than 100");			//If it is, then the console prints < 100
		} else {
			print("Number is more than 99");		//If it isn't, then the console prints > 99
		}
		if(num1 == 100){							//Checks if number is 100
				print("Number is equal to 100");	//If it is, prints = 100
			}

		if(Age >= 18) {			//If age is greater than or equal to 18, you are an adult.
			print("Adult");
		} else {
			print("Child");		//If age is less than or equal 18, you are a child.
		} if (Age <= 5) {
			print("Toddler");	//If age is less than or equal to 5, you are a child and Toddler.
		}
		if(Age >= 60){
			print("Senior");	//If age is greater than or equal to 60, you are an adult and senior.
		}
	}

	void Update () {

		//When Who toggle is on, who is displayed, and all other toggles are !on.
		if (toggle.isOn) {
			text.text = "Who?";
			toggle2.isOn = false;
			toggle3.isOn = false;
			toggle4.isOn = false;
		}
		//When What toggle is on, who is displayed, and all other toggles are !on.
		if (toggle2.isOn) {
			text.text = "What?";
			toggle.isOn =  false;
			toggle3.isOn = false;
			toggle4.isOn = false;
		}
		//When Where toggle is on, who is displayed, and all other toggles are !on.
		if (toggle3.isOn) {
			text.text = "Where?";
			toggle.isOn =  false;
			toggle2.isOn = false;
			toggle4.isOn = false;
		}
		//When Why toggle is on, who is displayed, and all other toggles are !on.
		if (toggle4.isOn) {
			text.text = "Why?";
			toggle.isOn =  false;
			toggle2.isOn = false;
			toggle3.isOn = false;
		}
	}
}
