using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public int playerLives = 3;  
    public int coins = 0;  
    public event Action<int> OnLifeUpdate; 
    public event Action<int> OnCoinUpdate;  
    public event Action OnWin;  
    public event Action OnLose;  

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void GainCoin()
    {
        coins = coins + 1; 
        OnCoinUpdate?.Invoke(coins);  
        CheckWin();  
    }

    public void ModifyLife(int cant)
    {
        playerLives = playerLives + cant;
        OnLifeUpdate?.Invoke(playerLives);  
        ValidateLife();  
    }

    private void CheckWin()
    {
        if (coins >= 10)
        {
            OnWin?.Invoke(); 
        }
    }

    private void ValidateLife()
    {
        if (playerLives <= 0)
        {
            OnLose?.Invoke();  
        }
    }
}