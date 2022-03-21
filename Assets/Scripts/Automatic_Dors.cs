using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automatic_Dors : MonoBehaviour
{

    public Animator doorAnimator; //el animator de la puerta que queremos abrir

 
    private void OnTriggerStay(Collider other) //al entrar al trigger que hay situado en la entrada de la puerta
    {
        doorAnimator.SetBool("openDor", true); //activamos la animación de abrir la puerta
    }

    private void OnTriggerExit(Collider other) //si salimos del trigger
    {
        doorAnimator.SetBool("openDor", false); //la puerta se cerrará automáticamente
    }
}
