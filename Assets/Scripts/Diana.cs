using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana : MonoBehaviour
{
    public ParticleSystem DestroyParticleSystem;
    private float lifetime = 7f;
    private SpawnManager spawnManagerScript;
    void Start()
    {
        spawnManagerScript = FindObjectOfType<SpawnManager>();
        Destroy(gameObject, lifetime);
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        Instantiate(DestroyParticleSystem, transform.position, DestroyParticleSystem.transform.rotation);
        spawnManagerScript.score++;
        Debug.Log(spawnManagerScript.score);
        Destroy(gameObject);
    }
    private void OnDestroy()
    {
        spawnManagerScript.targetPositions.Remove(transform.position);
       
    }
}
