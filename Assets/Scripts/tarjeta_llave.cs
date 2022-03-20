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
            puertaLlaveScript.hasKey = true;
            Destroy(gameObject);
            
        }
    }

}
