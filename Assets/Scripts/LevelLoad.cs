using UnityEngine;

public class LevelLoad : MonoBehaviour
{
    private void Start()
    {
        MainGameplay.NotifyGameState += GameStateHandler;
        gameObject.SetActive(false);
    }

    private void GameStateHandler(bool state)
    {
        gameObject.SetActive(state);
    }
}
