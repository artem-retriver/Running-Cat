using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("UI:")]
    [SerializeField] private UIManager uIManager;
    [Header("Levels:")]
    [SerializeField] private Level level;
    private Level levels;
    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private TextMeshProUGUI coinsBestTextMenu;
    [SerializeField] private TextMeshProUGUI coinsBestTextLose;
    [SerializeField] private TextMeshProUGUI coinsBestTextGame;

    private int coins = 0;
    private int coinsBest;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Coins"))
        {
            coinsBest = PlayerPrefs.GetInt("Coins");
            coinsBestTextGame.text = coinsBest.ToString();
            coinsBestTextLose.text = coinsBest.ToString();
            coinsBestTextMenu.text = coinsBest.ToString();
        }

        uIManager.ShowMenuScreen();
    }

    public void IncreaseCoins()
    {
        coins++;
        coinText.text = coins.ToString();

        if(coinsBest < coins)
        {
            coinsBest++;
        }
        
        coinsBestTextGame.text = coinsBest.ToString();
        coinsBestTextLose.text = coinsBest.ToString();
        coinsBestTextMenu.text = coinsBest.ToString();
        PlayerPrefs.SetInt("Coins", coinsBest);
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void CreateLevel()
    {
        levels = Instantiate(level);
        levels.Initialize(this);

    }

    public void DestroyLevel()
    {
        Destroy(levels.gameObject);
    }

    public void StartGame()
    {
        uIManager.ShowGameScreen();
        CreateLevel();
    }

    public void LoseGame()
    {
        uIManager.ShowLoseScreen();
        DestroyLevel();
        coins = 0;
        coinText.text = "0";
    }
}
