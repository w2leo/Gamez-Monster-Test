using System.Collections;
using System.Collections.Generic;
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
        Instantiate(playerPrefab, GameValues.GetRandomPosition(xPlayerSpawn, GameValues.yBound), Quaternion.identity);
    }
}
