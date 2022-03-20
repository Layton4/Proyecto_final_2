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
        puertallaveSript = FindObjectOfType<puertaLlave>();

        leveranimator = GetComponent<Animator>();
        elevatoranimator = GameObject.Find("ascensor1").GetComponent<Animator>();
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            elevatoranimator.SetBool("baja", true);
        }
    }

    public void OnTriggerEnter(Collider othercollider)
    {
            if (gameObject.CompareTag("palanca") && othercollider.gameObject.CompareTag("misil"))
            {
                Debug.Log("Diste en la diana");
                Destroy(othercollider.gameObject);
                leveranimator.SetBool("activate", true);
                elevatoranimator.SetBool("sube", true);   
            }

            if (puertallaveSript.hasKey == true)
            {
                Debug.Log("bajando");
                elevatoranimator.SetBool("baja", true);
            }
           
        
    }
}
