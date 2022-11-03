using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    [SerializeField] private Wall wallPrefab;
    [SerializeField] private float xSpawnPosition;
    [SerializeField] private MainGameplay gameplay;
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
        Vector2 spawnPosition = RandomPosition.GetRandomPosition(xSpawnPosition);
        MoveLeft item = ObjectPooler.SharedInstance.GetPooledObject().GetComponent<MoveLeft>();
        item.gameObject.SetActive(true);
        item.transform.position = spawnPosition;
        lastSpawnDistance = gameplay.Distance;
    }

    private bool ReadyToSpawn()
    {
        Debug.Log($" GP dist = {gameplay.Distance}");
        return (gameplay.Distance - lastSpawnDistance) > distanceToSpawn;
    }
}
