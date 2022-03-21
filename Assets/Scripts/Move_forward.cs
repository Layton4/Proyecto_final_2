using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_forward : MonoBehaviour
{
    public ParticleSystem DestroyParticleSystem;
    private float speed = 60f;
    private float lifetime = 4f;
    void Start()
    {
        Destroy(gameObject, lifetime); //las balas se destruiran solas después de cierto tiempo para no acumularlas en el campo
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);   //en todo momento se mueven hacia adelante
    }

    private void OncollisionEnter(Collider other) //si se chocan con algo se destruirán
    {
        Destroy(gameObject);
    }

    private void OnDestroy() //al destruirse instancian unas particulas
    {
        Instantiate(DestroyParticleSystem, transform.position, DestroyParticleSystem.transform.rotation);
    }

}
