using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tarjeta_llave : MonoBehaviour
{
    private float turnspeed = 30f;
    private puertaLlave puertaLlaveScript;
    void Start()
    {
        puertaLlaveScript = FindObjectOfType<puertaLlave>();
    }

   
    void Update()
    {
        transform.Rotate(Vector3.up * turnspeed * Time.deltaTime); //la llave estará constantemente girando sobre su eje Y
    }

    public void OnTriggerEnter(Collider other) //si nos acercamos a la llave
    {
        if(other.gameObject.CompareTag("Player")) //el Player podrá coger la llave
        {

        puertaLlaveScript.hasKey = true;
        Destroy(gameObject);
   
        }

        

    }

}
