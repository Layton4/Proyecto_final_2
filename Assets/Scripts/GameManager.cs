using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI HowPlayPanel;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Instructions()
    {

    }
    public void exit()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }

}
