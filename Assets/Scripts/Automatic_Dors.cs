using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automatic_Dors : MonoBehaviour
{

    public Animator doorAnimator;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        doorAnimator.SetBool("openDor", true);
    }

    private void OnTriggerExit(Collider other)
    {
        doorAnimator.SetBool("openDor", false);
    }
}
