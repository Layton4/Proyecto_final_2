using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sacar_puente : MonoBehaviour
{
    public bool pruebaDisparo;
    private Animator puenteanimation;
    private SpawnManager spawnManagerScript;
    void Start()
    {
        pruebaDisparo = false;
        spawnManagerScript = FindObjectOfType<SpawnManager>();
        puenteanimation = GameObject.Find("pasillo_oculto").GetComponent<Animator>();
    }

    
    void Update()
    {
        if(spawnManagerScript.currentScore>=10) //si superamos la puntuación de 10 puntos, o sea 10 dianas acertadas el puente se abrirá y podremos cruzar al otro lado
        {
            Debug.Log("has ganado!!");
            puenteanimation.SetBool("abre", true);
            pruebaDisparo = true;
        }
    }
}
