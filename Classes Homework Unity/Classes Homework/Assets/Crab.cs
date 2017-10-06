﻿using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class Crab : Animal { 
	public override void Start(){ 
		base.Start (); 
		Pinch (); 
	} 
	void Pinch(){ 
		print (this.name + " Pinch"); 
	} 

} 