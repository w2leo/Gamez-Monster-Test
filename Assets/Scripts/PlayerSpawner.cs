using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private Player playerPrefab;
    private const float xPlayerSpawn = -10f;

    private void Start()
    {
        SpawnPlayer();
    }

    private void SpawnPlayer()
    {
        Player player =  Instantiate(playerPrefab, RandomPosition.GetRandomPosition(xPlayerSpawn), Quaternion.identity);
    }
}
