using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject cabine;

    private float moveForce = 700;
    private float HorizontalInput;
    private float VerticalInput;

    private float speed = 10;
    private float turnspeed = 2;
    private Rigidbody playerRigidbody;
    private Rigidbody cabineRigidbody;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        playerRigidbody.AddForce(gameObject.transform.forward * VerticalInput * speed * moveForce);
        transform.Rotate(Vector3.up * HorizontalInput * turnspeed);
    }
}
