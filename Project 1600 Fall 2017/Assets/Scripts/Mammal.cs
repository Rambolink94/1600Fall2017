using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : Animal {
	public override void Start(){
		base.Start ();
		Shed ();
	}
	void Shed(){
		print (this.name + " Shed");
	}

}
