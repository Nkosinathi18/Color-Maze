using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public bool isStart;
    public bool isQuit;

    [SerializeField]
    private GameObject pauseMenu;
    [SerializeField]
    private GameObject _pauseButton;

    public void QuitGame()
    {
        Application.LoadLevel(0);
    }

    public void Menu()
    {
        Application.LoadLevel(0);
    }

    public void pauseButton()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        _pauseButton.SetActive(false);
    }
    public void unpauseButton()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        _pauseButton.SetActive(true);
    }


}
