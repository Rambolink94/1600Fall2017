using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators : MonoBehaviour {

    public int age;
    public int support;
    public int morale;
    public bool heir;
    public bool usurper;
    public bool raisedLevies;
    public bool male;
    public bool purpose;
    public bool fatherWasKing;
    public bool youOldestSon;

    void Update()
    {
        //Are you worthy to become king?
        if ((male == true || usurper == true) && age >= 16 && (heir == true || usurper == true))
        {
            print("You are worthy to become king");
        }
        else {
            print("You are not worthy to become king");
        }
        //Do you have the power to Usurpe?
        if (raisedLevies == true && (support >= 1000 || morale >= 65) && purpose == true)
        {
            print("You have the power to usurp");
        }
        else {
            print("You do not yet have the power to usurp");
        }
        //Are you the rightfull heir to the throne?
        if (fatherWasKing == true && youOldestSon == true)
        {
            print("You are the rightfull heir to the throne");
        }
        else {
            print("You are not the rightfull heir to the throne");
        }
    }
}
