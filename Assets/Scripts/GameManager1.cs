using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager1 : MonoBehaviour
{
    public GameObject PanelWin;
    void Start()
    {
        PanelWin.SetActive(false);
    }

    public void PlayAgain()
    {
        PanelWin.SetActive(false);
        SceneManager.LoadScene(1);
    }
}
