using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subir_ascensor : MonoBehaviour
{

    private Animator leveranimator;
    private Animator elevatoranimator;


    public puertaLlave puertallaveSript;
    void Start()
    {
        puertallaveSript = FindObjectOfType<puertaLlave>(); //accederemos al script de puertaLlave

        leveranimator = GetComponent<Animator>(); //accedemos a la animación de la palanca
        elevatoranimator = GameObject.Find("ascensor1").GetComponent<Animator>(); //accedemos a la animación del ascensor
        
    }


    public void OnTriggerEnter(Collider othercollider)
    {
            if (gameObject.CompareTag("palanca") && othercollider.gameObject.CompareTag("misil")) //si un misil impacta con la palanca
            {
                Debug.Log("Diste en la diana");
                Destroy(othercollider.gameObject); //destruimos el misil
                leveranimator.SetBool("activate", true); //activamos el movimiento de la palanca
                elevatoranimator.SetBool("sube", true); //el ascensor sube a la segunda planta
            }

            if (puertallaveSript.hasKey == true) //arriba accedemos a la llave que buscamos y si nos subimos al ascensor con la llave
            {
                Debug.Log("bajando"); //bajamos con el ascensor a la planta baja otra vez
                elevatoranimator.SetBool("baja", true);
            }
           
        
    }
}
