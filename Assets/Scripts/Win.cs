using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Win : MonoBehaviour
{
    private bool youWin;
    public GameObject WinScrean;
    private SpawnManager SpawnManagerScript;


    public Text TimePanel;
    public Reloj RelojScript;



    void Start()
    {
        SpawnManagerScript = FindObjectOfType<SpawnManager>();
        youWin = false;
        WinScrean.SetActive(false);
    }

    void Update()
    {
        if (youWin)
        {
            WinScrean.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
         youWin = true;
         RelojScript.timeScale = 0;
    }
}
