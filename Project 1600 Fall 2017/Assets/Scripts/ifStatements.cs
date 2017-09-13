using System.Collections;
using UnityEngine; 
using UnityEngine.UI; 
 
public class ifStatements : MonoBehaviour { 
 
  public int num1; 
  public int num2; 
  public int value; 
 
  public bool canPlay = true; 
  public Text input; 
  public string password = "Rambo"; 
 
  void Start (){ 
    if(num1 + num2 == value){ 
      print (value); 
    } 
    if (canPlay) { 
      print ("Play");     
    } else { 
      print ("Can't Play"); 
    } 
    if (input.text == password) { 
      print ("You know the password"); 
    } else { 
      print ("You don't know the password"); 
    } 
  } 
  void Update (){ 
    if (input.text == password) { 
      print ("You know the password"); 
    } else { 
      print ("You don't know the password"); 
    } 
  } 
} 