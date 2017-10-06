﻿using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class Fish : Animal { 

	void Swim(){ 
		print (this.name + " Swims"); 
	} 

	public override void Start(){ 
		base.Start (); 
		Swim (); 
	} 
} 
