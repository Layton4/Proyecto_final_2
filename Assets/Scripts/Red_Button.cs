using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_Button : MonoBehaviour
{

    public Animator puerta_cerrada;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        puerta_cerrada.SetBool("openDor", true);
    }
}
