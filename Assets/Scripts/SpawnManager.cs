using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject objectiveprefab;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public void spawnObjective()
    {
        if(ingame)
        {
            Instantiate(objectiveprefab, randomposition(), objectiveprefab.transform.rotation);
        }
        else
        {
            CancelInvoke();
        }
    }
}
