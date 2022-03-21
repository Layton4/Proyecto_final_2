using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject HowPlayPanel;
    void Start()
    {

    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Instructions()
    {
        HowPlayPanel.SetActive(true);
    }
    public void exit()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }

    public void returnMenu()
    {
        HowPlayPanel.SetActive(false);
    }

}
