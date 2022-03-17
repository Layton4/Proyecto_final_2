using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_forward : MonoBehaviour
{
    private float speed = 10f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);  
    }
}
