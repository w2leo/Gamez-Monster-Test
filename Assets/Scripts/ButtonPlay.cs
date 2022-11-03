using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class ButtonPlay : MonoBehaviour
{
    [SerializeField] private MainGameplay gameplay;

    private Difficulty difficulty;

    private void Start()
    {
        difficulty= Difficulty.Easy;
    }

    public void StartNewGame()
    {
        Debug.Log($"Current diff = {difficulty}");
        gameplay.StartNewGame(difficulty);
    }

    public void SetDifficulty(Difficulty difficulty)
    {
        this.difficulty = difficulty;
        Debug.Log($"Diff changed to {difficulty}");
    }
}
