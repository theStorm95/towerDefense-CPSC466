using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;
    public GameManager gameManager;
    
    public Transform startPoint;
    public Transform[] path;

    public int currency;
    public int roundLives;
    private bool isDead;
    
    public void Awake()
    {
        main = this;
    }

    private void Start() 
    {
        currency = 100;
        roundLives = 5;
    }

    public void IncreaseCurrency(int amount) 
    {
        currency += amount;
    }

    public bool SpendCurrency(int amount) 
    {
        if (amount <= currency) {
            currency -= amount;
            return true;
        } else {
            return false;
        }
    }

    public void Update() 
    {
        if (roundLives <= 0 && !isDead)
        {
            isDead = true;
            gameManager.gameOver();
        }
    }
}
