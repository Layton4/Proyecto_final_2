using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertaLlave : MonoBehaviour
{
    private Animator keyDor;
    public bool hasKey;
    public bool hasKey2;
    public GameObject advertencia;
    void Start()
    {
        hasKey = false; //bolean que comprueba si has cogido la llave para abrir la puerta
        keyDor = GameObject.Find("puerta1").GetComponent<Animator>(); //animator de la puerta que queremos abrir
    }

    public void OnTriggerEnter(Collider other) //al entrar al trigger que hemos situado en el suelo cerca de la puerta
    {
        if(hasKey) //si tiene la llave
        {
            keyDor.SetBool("openDor", true); //abrirá la puerta
        }

    }

    public void OnTriggerStay(Collider other) //si no hemos cogido la llave y queremos ir por esa puerta saltará un mensaje que nos dirá que vayamos a buscar la llave
    {
        if(!hasKey)
        {
            advertencia.SetActive(true);
        }
        else //en caso de tener la llave el mensaje se desactiva
        {
            advertencia.SetActive(false);
        }
    }

    public void OnTriggerExit(Collider other) //si nos alejamos del trigger el mensaje no aparecerá
    {
        advertencia.SetActive(false);
    }



}
