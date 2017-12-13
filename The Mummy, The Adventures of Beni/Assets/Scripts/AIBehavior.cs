using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class AIBehavior : MonoBehaviour {

    public Transform player;
    public ParticleSystem deathEmitter;
    public NavMeshAgent agent;
    public static float health = 50;

    void Update()
    {
        // Makes AI follow player.
        agent.destination = player.position;
        agent.updateRotation = false;
        if (health <= 0)
        {
            StartCoroutine(DeathEffects());
        }
    }

    IEnumerator DeathEffects() {
        deathEmitter.Play();
        if (deathEmitter.isPlaying == true)
        {
            yield return new WaitUntil(() => deathEmitter.isPlaying == false);
        }
        Destroy(gameObject);
    }


}
