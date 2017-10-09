using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHider : MonoBehaviour {

    public bool menuHidden = false;

    public void ToggleMenu() {
        if (menuHidden == true)
        {
            menuHidden = false;
        }
        else
        {
            menuHidden = true;
        }
    }
}
