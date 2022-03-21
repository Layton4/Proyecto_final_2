using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_game : MonoBehaviour
{

    public bool gameOn;
    public SpawnManager spawnManagerScript;
    void Start()
    {
        gameOn = false;
        spawnManagerScript = FindObjectOfType<SpawnManager>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameOn = true;
            spawnManagerScript.score = 0;
            StartCoroutine(Playtime());
        }
        
    }

    private IEnumerator Playtime()
    {
        StartCoroutine(spawnManagerScript.spawnObjective());
        yield return new WaitForSeconds(30);
        gameOn = false;
        Debug.Log("Se acabó");
        StopCoroutine(spawnManagerScript.spawnObjective());
    }

}
