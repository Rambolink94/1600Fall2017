using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmRotation : MonoBehaviour {

    // Integer that allows designer to offset arms rotation
    public static int RotDebug = -112;

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;    // Finds the mouse's input and location
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);    // Stores the location of the mouse on the screen
        mousePosition = mousePosition - screenPosition;     // Finds the difference between the mouse's position and a point on the world space.
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg - RotDebug));
        // rotates the arm, using Quaternion.Euler, which rotates based on predefined floats. Mathf.Atan2 finds the angle between a given point and the x axis. Mathf.Rad2Deg converts radians to degrees.
    }
}

// References to Quaternion.Euler, Mathf.Atan2, and Mathf.Rad2Deg
//https://docs.unity3d.com/ScriptReference/Mathf.Atan2.html
//https://docs.unity3d.com/ScriptReference/Mathf.Rad2Deg.html
//https://docs.unity3d.com/ScriptReference/Quaternion.Euler.html
