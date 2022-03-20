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

    void Start()
    {
        //playerRigidbody = GetComponent<Rigidbody>();
        cabine = GameObject.Find("cabina_superior");
        canon = GameObject.Find("canon");
    }


    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        //playerRigidbody.AddForce(Vector3.forward * speed * VerticalInput * moveForce);
        
        transform.Rotate(Vector3.up * HorizontalInput * turnspeed * 2 * Time.deltaTime);
        transform.Translate(Vector3.forward * VerticalInput * speed * Time.deltaTime);
        //playerRigidbody.AddForce(gameObject.transform.forward * VerticalInput * moveForce);

        if(Input.GetKey(KeyCode.Q))
        {
            cabine.transform.Rotate(Vector3.up * -turnspeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            cabine.transform.Rotate(Vector3.up * turnspeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.R))
        {
            canon.transform.Rotate(Vector3.left * turnspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.F))
        {
            canon.transform.Rotate(Vector3.right * turnspeed * Time.deltaTime);
        }
        /*float MouseY = Input.GetAxis("Mouse Y") * mouseSentivility * Time.deltaTime;
        xRotation = -MouseY;
        xRotation = Mathf.Clamp(xRotation, -19f, 20f);

        canon.transform.Rotate(Vector3.right * xRotation);*/

    }
}
