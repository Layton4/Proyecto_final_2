using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveForce = 1000;
    public float rotateForce = 50;
    private float HorizontalInput;
    private float VerticalInput;

    public float speed = 20;
    private float turnspeed = 15;
    private Rigidbody playerRigidbody;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        //playerRigidbody.AddForce(Vector3.forward * speed * VerticalInput * moveForce);
        
        transform.Rotate(Vector3.up * HorizontalInput * turnspeed * rotateForce* Time.deltaTime);
        //transform.Translate(Vector3.forward * VerticalInput * speed * Time.deltaTime);
        playerRigidbody.AddForce(gameObject.transform.forward * VerticalInput * moveForce);
    }
}
