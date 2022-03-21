using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Reloj : MonoBehaviour
{
    public int initialTime; //tiempo inicial en segundos
    [Range(-40.0f,40f)]
    public float timeScale = 1; //como de rápido irá el reloj y si irá para alante o atrás el tiempo;


    private Text myText;
    private float frameTimeScale = 0f;
    public float timeToShow = 0f;
    private float initialTimeScale;
    void Start()
    {
        initialTimeScale = timeScale; //paso normal del tiempo;
        myText = GetComponent<Text>(); //accedemos a la compenente text del texto
        timeToShow = initialTime; //el tiempo en el que empezaremos a contar, en este caso al ser un cronometro será 0

        ActualizarReloj(initialTime);
    }


    void Update()
    {
        frameTimeScale = Time.deltaTime * timeScale;
        timeToShow += frameTimeScale;
        ActualizarReloj(timeToShow); //llamaremos a la función en update para que lo compruebe siempre y le indicamos en que tiempo empezamos con timeToShow
    }

    public void ActualizarReloj(float timeInSeconds)
    {
        int minuts = 0;
        int seconds = 0;
        string textoDelReloj;

        if (timeInSeconds < 0) timeInSeconds = 0;
        minuts = (int)timeInSeconds / 60; //así calcularemos cuantos minutos son los segundos que llevamos
        seconds = (int)timeInSeconds % 60; //el resto serán segundos

        textoDelReloj = minuts.ToString("00") + ":" + seconds.ToString("00"); //convertimos en string los minutos y segundos para mostrarlos por pantalla
        myText.text = textoDelReloj; //y lo metemos en la variable para que podamos verlo en el juego
    }
    
}
