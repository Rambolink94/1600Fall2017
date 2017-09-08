using UnityEngine;
public class Variables : MonoBehaviour {
    public float health = 100;
    void OnTriggerEnter()
    {
        health += 20;
    }
}
