using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zona_impulso : MonoBehaviour
{

    private float impulseForce = 6f;
    private Rigidbody playerRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GameObject.Find("player_v5").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        playerRigidbody.AddForce(Vector3.up * impulseForce, ForceMode.Impulse);
    }
}
