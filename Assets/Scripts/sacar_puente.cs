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
        //int currentScore = spawnManagerScript.score;
        if(spawnManagerScript.currentScore>=10)
        {
            Debug.Log("has ganado!!");
            puenteanimation.SetBool("abre", true);
            pruebaDisparo = true;
        }
    }
}
