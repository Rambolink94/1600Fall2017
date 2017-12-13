using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class AIBehavior : MonoBehaviour {

    public Transform player;
    public ParticleSystem deathEmitter;
    private SpriteRenderer[] colorAlpha;
    public NavMeshAgent agent;
    public float health = 60;

    void Start()
    {
        // Collects and stores all of the gameobject's children's sprite renderers.
        SpriteRenderer[] colorAlpha = GetComponentsInChildren<SpriteRenderer>();
    }

    void Update()
    {
        // Makes AI follow player.
        agent.destination = player.position;
        agent.updateRotation = false;
        if (health <= 0)
        {
            Debug.Log(health);
            StartCoroutine(DeathEffects());
        }
    }

    IEnumerator DeathEffects() {
        /*
       for (int i = 0; i < colorAlpha.Length; i++)
       {
           colorAlpha[i].color = new Color(1, 1, 1, 0);
           Debug.Log(colorAlpha[i].name);
            // Changing all of the childrens sprite renderer's Alpha to 0. That way it disapears, but still exists.
       }
        deathEmitter.Play();
        Debug.Log("Code got here");
        var em = deathEmitter.emission;
        em.enabled = true;

        if (deathEmitter.isPlaying == true)
        {
            yield return new WaitUntil(() => deathEmitter.isPlaying == false);
        }
        // Finally destroys the object
        */
        Destroy(gameObject);
        yield return null;
    }


}
