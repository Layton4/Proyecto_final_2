using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Win : MonoBehaviour
{
    public bool youWin;
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

    void Update() //si la variable YouWin es true activaremos la pantalla de victoria
    {
        if (youWin)
        {
            WinScrean.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other) //al tocar el trigger de la bandera de victoria
    {
         youWin = true; //la variable YouWin será True
         RelojScript.timeScale = 0; //y el cronometro parará
    }
}
