using System;
using UnityEngine;

[Serializable]
public class ButtonPlayState : MonoBehaviour
{
    [SerializeField] private MainGameplay gameplay;
    [SerializeField] private MenuController menuController;

    private void Start()
    {
        SetDifficulty(Difficulty.Easy);
    }

    public void ChangeGameState(bool state)
    {
        gameplay.SetGameState(state);
        menuController.SetMenu(state ? MenuType.GameUI : MenuType.EndMenu);
    }

    public void SetDifficulty(Difficulty difficulty)
    {
        gameplay.CurrentDifficulty = difficulty;
    }
}
