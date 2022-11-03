using UnityEngine;

public class Player : MonoBehaviour
{
    private MainGameplay gameplay;

    private void Start()
    {
        gameplay = FindObjectOfType<MainGameplay>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out Wall _))
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        gameplay.SetGameState(false);
    }
}
