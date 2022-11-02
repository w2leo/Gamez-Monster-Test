using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum Difficulty
{
    Easy = 2,
    Medium = 3,
    Hard = 4
}

public class MainGameplay : MonoBehaviour
{
    private const float basicMoveSpeed = 10;
    private int attempCount;
    private float attempTimer;

    private float gameSpeed;
    private Difficulty currentDifficulty;

    public float Distance { get; private set; }
    public bool GameIsActive { get; private set; }
    public float AttempTime => attempTimer;
    public int AttempCount => attempCount;
    public float DifficultyMultiplier => (float)currentDifficulty / 2;
    public float GameSpeed => basicMoveSpeed * DifficultyMultiplier;
    void Start()
    {
        attempCount = 0;
        StartNewGame(Difficulty.Hard);
    }

    public void StartNewGame(Difficulty difficulty)
    {
        currentDifficulty = difficulty;
        GameIsActive = true;
        Distance = 0;
        attempCount++;
        gameSpeed = basicMoveSpeed * DifficultyMultiplier;
    }


    void Update()
    {
        if (GameIsActive)
        {
            attempTimer += Time.deltaTime;
            Distance += gameSpeed * Time.deltaTime;
        }
    }
}
