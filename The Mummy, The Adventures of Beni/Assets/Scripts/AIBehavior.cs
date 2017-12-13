using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBehavior : MonoBehaviour {

    public Transform player;
    public float speed = 6;
    public float minFollowDistance = 1;
    public float maxFollowDistance = 20;

    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) >= minFollowDistance)
        {
           transform.Translate (Vector2.MoveTowards(transform.position, player.position, maxFollowDistance) * speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, player.position) <= maxFollowDistance)
        {
            
        }
    }


}
