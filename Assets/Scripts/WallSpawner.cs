using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    [SerializeField] private Wall wallPrefab;
    [SerializeField] private float xSpawnPosition;
    [SerializeField] private Background background;
    [SerializeField] private int distanceToSpawn;

    private float lastSpawnDistance;

    private void Start()
    {
        lastSpawnDistance = 0;
    }

    private void Update()
    {
        if (ReadyToSpawn())
        {
            SpawnItem();
        }
    }

    private void SpawnItem()
    {
        Vector2 spawnPosition = GameValues.GetRandomPosition(xSpawnPosition, GameValues.yBound);
        GameObject item = ObjectPooler.SharedInstance.GetPooledObject();
        item.SetActive(true);
        item.transform.position = spawnPosition;
        lastSpawnDistance = background.Distance;
    }

    private bool ReadyToSpawn()
    {
        return (background.Distance - lastSpawnDistance) > distanceToSpawn;
    }
}
