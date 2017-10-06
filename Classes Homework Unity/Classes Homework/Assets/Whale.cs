﻿using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class Whale : Mammal { 

	public override void Start(){ 
		base.Start (); 
		Jet (); 
	} 
	void Jet(){ 
		print (this.name + " Jet"); 
	} 
} 