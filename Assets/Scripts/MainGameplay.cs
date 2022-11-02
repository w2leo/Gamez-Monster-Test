using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Difficulty
{
    Easy = 2, 
    Medium = 3, 
    Hard = 4
}

public class MainGameplay : MonoBehaviour
{
    private int attempCount;
    private float attempTimer;
    private float playerSpeed;
    private float gameSpeed;
    private Difficulty difficulty;


    public bool GameIsActive { get; private set; }
    public float AttempTime => attempTimer;
    public int AttempCount => attempCount;
    public float DifficultyMultiplier => (float)difficulty / 2;
    public float PlayerSpeed => playerSpeed;
    public float GameSpeed => gameSpeed;
    void Start()
    {
        attempCount = 0;
        StartNewGame(Difficulty.Easy);
    } 

    public void StartNewGame(Difficulty difficulty)
    {
        GameIsActive = true;
        attempCount++;
        playerSpeed = GameValues.basicPlayerSpeed;
        gameSpeed = GameValues.basicMoveLeftSpeed * DifficultyMultiplier;
    }


    void Update()
    {
        if (GameIsActive)
        {
            attempTimer += Time.deltaTime;
        }     
    }
}
