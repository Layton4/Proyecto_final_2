using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject misilprefab;
    public Vector3 offset = new Vector3(0, 0, 2);
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(misilprefab, transform.position + offset, misilprefab.transform.rotation);
        }
    }
}
