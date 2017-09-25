using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour {
	public List<GameObject> myWeapons;

	void OnTriggerEnter(Collider _weapon){
		myWeapons.Add (_weapon.gameObject);
		}
}
