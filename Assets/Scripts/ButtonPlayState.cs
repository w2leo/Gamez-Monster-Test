using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class ButtonPlayState : MonoBehaviour
{
    [SerializeField] private MainGameplay gameplay;
    [SerializeField] private MenuController menuController;
    [SerializeField] private GameObject level;

    private void Start()
    {
        SetDifficulty(Difficulty.Easy);
    }

    public void ChangeGameState(bool state)
    {
        gameplay.SetGameState(state);
        menuController.SetMenu(state ? MenuType.GameUI : MenuType.EndMenu);
        level.SetActive(state);
    }

    public void SetDifficulty(Difficulty difficulty)
    {
        gameplay.CurrentDifficulty = difficulty;
    }
}
