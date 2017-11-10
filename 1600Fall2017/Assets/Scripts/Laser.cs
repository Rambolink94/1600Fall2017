using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

	public Transform start;
	public Transform end;
	public LineRenderer line;

	// Update is called once per frame
	void Update () {
		line.SetPosition (0, start.position);
		line.SetPosition (1, end.position);
	}
}
