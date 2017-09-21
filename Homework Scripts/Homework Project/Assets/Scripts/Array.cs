using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour {

    public string[] powerUp;

    void Start()
    {
        foreach (string i in powerUp) {
            print(i);
        }
    }
}
