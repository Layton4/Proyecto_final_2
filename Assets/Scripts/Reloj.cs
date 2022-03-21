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
        myText = GetComponent<Text>(); //accedemos a la compenente text
        timeToShow = initialTime;

        ActualizarReloj(initialTime);
    }


    void Update()
    {
        frameTimeScale = Time.deltaTime * timeScale;
        timeToShow += frameTimeScale;
        ActualizarReloj(timeToShow);
    }

    public void ActualizarReloj(float timeInSeconds)
    {
        int minuts = 0;
        int seconds = 0;
        string textoDelReloj;

        if (timeInSeconds < 0) timeInSeconds = 0;
        minuts = (int)timeInSeconds / 60;
        seconds = (int)timeInSeconds % 60;

        textoDelReloj = minuts.ToString("00") + ":" + seconds.ToString("00");
        myText.text = textoDelReloj;
    }
    
}
