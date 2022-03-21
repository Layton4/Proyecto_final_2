using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_Button : MonoBehaviour
{

    public Animator puerta_cerrada; //animator de la puerta que queremos abrir

    public void OnTriggerEnter(Collider other) //al ponernos sobre el boton
    {
        puerta_cerrada.SetBool("openDor", true); //abriremos la puerta
    }
}
