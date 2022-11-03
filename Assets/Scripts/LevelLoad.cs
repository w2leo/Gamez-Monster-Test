using UnityEngine;

public class LevelLoad : MonoBehaviour
{
    private void Start()
    {
        MainGameplay.NotifyGameState += GameStateHandler;
    }

    private void GameStateHandler(bool state)
    {
        gameObject.SetActive(true);
    }
}
