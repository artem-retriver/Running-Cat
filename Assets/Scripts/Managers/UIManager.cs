using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject menuScreen;
    [SerializeField] private GameObject gameScreen;
    [SerializeField] private GameObject loseScreen;
    [SerializeField] private GameObject pauseScreen;

    private GameObject _currentScreen;

    public void Awake()
    {
        _currentScreen = menuScreen;
    }

    public void ShowMenuScreen()
    {
        _currentScreen.SetActive(false);
        menuScreen.SetActive(true);
        _currentScreen = menuScreen;
    }

    public void ShowGameScreen()
    {
        _currentScreen.SetActive(false);
        gameScreen.SetActive(true);
        _currentScreen = gameScreen;
    }

    public void ShowLoseScreen()
    {
        _currentScreen.SetActive(false);
        loseScreen.SetActive(true);
        _currentScreen = loseScreen;
    }

    public void ShowPauseScreen()
    {
        _currentScreen.SetActive(false);
        pauseScreen.SetActive(true);
        _currentScreen = pauseScreen;
    }
}


