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

    private int playtime = 40;
    void Start()
    {
        GamePanel.SetActive(false); //aseguramos que no se vea el panel del juego de los disparos al empezar el juego
        RelojScript = juego_text.GetComponent<Reloj>(); //accedemos al script que tiene la cuenta atr�s de cuanto dura la partida;
        gameOn = false; //por defecto juego est� desactivado
        spawnManagerScript = FindObjectOfType<SpawnManager>(); //accederemos al script SpawnManager
    }

    private void OnTriggerEnter(Collider other) //cuando pisemos el bot�n
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameOn = true; //activamos el minijuego
            spawnManagerScript.score = 0; //la puntuaci�n inicial es 0
            StartCoroutine(Playtime()); //la partida durar� una cantidad de segundos
            RelojScript.timeScale = -1; //queremos que el tiempo con cuenta atr�s
            RelojScript.timeToShow = playtime; //empezando a contar desde un cierto tiempo
            GamePanel.SetActive(true); //activamos el panel que nos ense�a la puntuaci�n que llevamos y la cuenta atr�s.
        }
        
    }

    private IEnumerator Playtime() //es una corrutina para controlar la duraci�n de la partida 
    {
        StartCoroutine(spawnManagerScript.spawnObjective()); //activamos el spawnManager
        yield return new WaitForSeconds(playtime); //sigue spawneando objetivos durante el tiempo playtime
        gameOn = false;
        Debug.Log("Se acab�");
        StopCoroutine(spawnManagerScript.spawnObjective()); //una vez terminado el tiempo apagamos la corroutine
        GamePanel.SetActive(false); //desactivamos el panel del minijuego
    }

}
