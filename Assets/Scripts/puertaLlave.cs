using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertaLlave : MonoBehaviour
{
    private Animator keyDor;
    public bool hasKey;
    public bool hasKey2;
    public GameObject advertencia;
    void Start()
    {
        hasKey = false;
        keyDor = GameObject.Find("puerta1").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(hasKey)
        {
            keyDor.SetBool("openDor", true);
        }

    }

    public void OnTriggerStay(Collider other)
    {
        if(!hasKey)
        {
            advertencia.SetActive(true);
        }
        else
        {
            advertencia.SetActive(false);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        advertencia.SetActive(false);
    }



}
