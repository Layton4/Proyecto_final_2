using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_forward : MonoBehaviour
{
    public ParticleSystem DestroyParticleSystem;
    private float speed = 60f;
    private float lifetime = 5f;
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);  
    }

    private void OncollisionEnter(Collider other)
    {
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        Instantiate(DestroyParticleSystem, transform.position, DestroyParticleSystem.transform.rotation);
    }

}
