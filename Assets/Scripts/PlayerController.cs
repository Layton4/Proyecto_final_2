using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //public float moveForce = 1000;
    //public float rotateForce = 50;
    private float HorizontalInput;
    private float VerticalInput;
    //private float xRotation;
    //private float mouseSentivility = 30;

    public float speed = 4;
    private float turnspeed = 50;
    //private Rigidbody playerRigidbody;
    private GameObject cabine;
    private GameObject canon;

    private Win winscript;

    void Start()
    {
        winscript = GameObject.Find("Bandera_Victoria").GetComponent<Win>();
        cabine = GameObject.Find("cabina_superior");
        canon = GameObject.Find("canon");
    }


    void Update()
    {
        if(!winscript.youWin)
        { 
            HorizontalInput = Input.GetAxis("Horizontal");
            VerticalInput = Input.GetAxis("Vertical");
        
            transform.Rotate(Vector3.up * HorizontalInput * turnspeed * 2 * Time.deltaTime);
            transform.Translate(Vector3.forward * VerticalInput * speed * Time.deltaTime);
       

            if(Input.GetKey(KeyCode.Q)) //mientras pulses la Q la cabina rotará a la izquierda
            {
                cabine.transform.Rotate(Vector3.up * -turnspeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.E)) //mientras pulses la tecla E la cabina rotará a la derecha
            {
                cabine.transform.Rotate(Vector3.up * turnspeed * Time.deltaTime);
            }

            if(Input.GetKey(KeyCode.R))//mientras pulses la tecla R el canon apuntará más arriba, rotará en x hacia arriba
            {
                canon.transform.Rotate(Vector3.left * turnspeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.F))//mientras pulses la tecla F el canon apuntará más abajo, rotará en x hacia abajo
            {
                canon.transform.Rotate(Vector3.right * turnspeed * Time.deltaTime);
            }
        }


    }
}
