using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class activate_game : MonoBehaviour
{
    public Text juego_text;
    public GameObject GamePanel;
    private Reloj RelojScript;
    public bool gameOn;
    private SpawnManager spawnManagerScript;
    void Start()
    {
        GamePanel.SetActive(false);
        RelojScript = juego_text.GetComponent<Reloj>();
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
            RelojScript.timeScale = -1;
            RelojScript.timeToShow = 31;
            GamePanel.SetActive(true);
        }
        
    }

    private IEnumerator Playtime()
    {
        StartCoroutine(spawnManagerScript.spawnObjective());
        yield return new WaitForSeconds(30);
        gameOn = false;
        Debug.Log("Se acabó");
        StopCoroutine(spawnManagerScript.spawnObjective());
        GamePanel.SetActive(false);
    }

}
