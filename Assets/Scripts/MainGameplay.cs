using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Search;
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
    private const float secToIncrease = 5f;
    private const float increaseSpeedValue = 1.1f;
    private float lastIncreased;
    private int attempCount;
    private float attempTimer;
    private float gameSpeed;
    private float distance;
    public Difficulty CurrentDifficulty { get; set; }

    public float Distance => distance;
    public bool GameIsActive { get; private set; }
    public float AttempTime => attempTimer;
    public int AttempCount => attempCount;
    public float DifficultyMultiplier => (float)CurrentDifficulty / 2;
    public float GameSpeed => gameSpeed;

    public delegate void GameStateHandler (bool gameState);
    public static event GameStateHandler NotifyGameState;

    void Start()
    {
        attempCount = 0;
    }

    private void StartNewGame(Difficulty difficulty)
    {
        CurrentDifficulty = difficulty;
        distance = 0;
        lastIncreased = 0;
        attempCount++;
        gameSpeed = basicMoveSpeed * DifficultyMultiplier;
    }

    public void SetGameState(bool state)
    {
        if (state)
        {
            StartNewGame(CurrentDifficulty);
        }
        else
        {
            StopGame();
        }
        GameIsActive = state;
        StartCoroutine(ChangeGameState(state));
    }

    IEnumerator ChangeGameState(bool state)
    {
        yield return null;
        NotifyGameState(state);
    }

    private void StopGame()
    {

        //Event -> stop game
        //Show MainMenu (with game stats)
        //Difficulty buttons
        //Start new Game
    }

    void Update()
    {
        if (GameIsActive)
        {
            attempTimer += Time.deltaTime;
            distance += gameSpeed * Time.deltaTime;
            TryToIncreaseGameSpeed();
        }
    }

    private void TryToIncreaseGameSpeed()
    {
        if ((attempTimer - lastIncreased) > secToIncrease)
        {
            lastIncreased = attempTimer;
            IncreaseGameSpeed(increaseSpeedValue);
        }
    }

    private void IncreaseGameSpeed(float increaseValue)
    {
        gameSpeed *= increaseValue;
    }
}
