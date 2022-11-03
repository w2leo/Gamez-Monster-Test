using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private Player playerPrefab;
    private const float xPlayerSpawn = -10f;
    private Player player;

    private void Awake()
    {
        CreatePlayer();
        MainGameplay.NotifyGameState += ChangeGameStateHandler;
    }

    private void CreatePlayer()
    {
        player = Instantiate(playerPrefab, RandomPosition.GetRandomPosition(xPlayerSpawn), Quaternion.identity);
        player.gameObject.SetActive(false);
    }

    private void ChangeGameStateHandler(bool gameState)
    {
        player.gameObject.SetActive(gameState);
        if (gameState)
        {
            player.transform.position = RandomPosition.GetRandomPosition(xPlayerSpawn);
        }
    }
}
