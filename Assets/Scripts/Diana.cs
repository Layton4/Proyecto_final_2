using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Diana : MonoBehaviour
{
    public ParticleSystem DestroyParticleSystem;
    private float lifetime = 6f;
    private SpawnManager spawnManagerScript;

    void Start()
    {
        spawnManagerScript = FindObjectOfType<SpawnManager>(); //accederemos al spawnManager
        Destroy(gameObject, lifetime); //la diana aunque no le demos desaparecerá tras su tiempo de vida (lifetime)
    }

    private void OnTriggerEnter(Collider other) //cuando lancemos un misil a la diana entraremos en su trigger
    {
        
        Instantiate(DestroyParticleSystem, transform.position, DestroyParticleSystem.transform.rotation); //instanciaremos unas particulas para indicar que le hemos dado
        spawnManagerScript.score++; //sumaremos 1 punto en el score por haberle dado
        Destroy(gameObject); //y se destruye así la diana
    }
    private void OnDestroy()//una vez se destruye deja libre su posición en el mapa y podemos eliminar esa posición de la lista de posiciones que hay guardada en el spawnManager
    {
        spawnManagerScript.targetPositions.Remove(transform.position);
       
    }
}
