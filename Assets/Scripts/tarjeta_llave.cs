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
        transform.Rotate(Vector3.up * turnspeed * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(gameObject.CompareTag("tarjeta1"))
            {
                puertaLlaveScript.hasKey = true;
                Destroy(gameObject);
            }

            else
            {
                puertaLlaveScript.haskey2 = true;
                Destroy(gameObject);
            }
        }

        

    }

}
