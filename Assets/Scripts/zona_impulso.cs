using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zona_impulso : MonoBehaviour
{

    private float impulseForce = 4f;
    private Rigidbody playerRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GameObject.Find("player_v5").GetComponent<Rigidbody>(); //accedemos al rigidbody del player
    }
    private void OnTriggerStay(Collider other) //si nos situamos dentro de la zona del trigger
    {
        playerRigidbody.AddForce(Vector3.up * impulseForce, ForceMode.Impulse); //una fuerza nos elevará arriba para poder mantenernos en el aire mientras estemos en contacto con el trigger
    }
}
