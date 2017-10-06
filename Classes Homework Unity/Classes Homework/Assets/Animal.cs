using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class Animal : MonoBehaviour { 

	public string[] animalFood = { "Bananas", "Apples", "Grapes", "Chicken", "Turkey", "Maple Bar" };
	public int[] foodCount = { 10, 2, 30, 1, 15, 207 };

	public virtual void Start () { 
		 
		for (int i = 0; i < animalFood.Length; i++) 
		{
			Eat (animalFood [i], foodCount [i]);
		}
		Sleep();
		Die(); 
	} 

	void Die (){ 
		print (this.name + " Dies"); 
	} 

	void Eat (string food, int amount){ 
		print (this.name + " likes to eat " + food); 
		print (this.name + " ate " + amount);
	} 

	void Sleep (){ 
		print (this.name + " Sleeps"); 
	} 
} 