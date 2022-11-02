using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEditor.AnimatedValues;
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
        if (CheckSpawnEnable())
        {
            SpawnItem();
        }
    }

    private Vector2 GetSpawnPosition()
    {
        return new Vector2(xSpawnPosition, Random.Range(-GameValues.yBound, GameValues.yBound));
    }

    private void SpawnItem()
    {
        Instantiate(wallPrefab, GetSpawnPosition(), Quaternion.identity, transform);
        lastSpawnDistance = background.Distance;
    }

    private bool CheckSpawnEnable()
    {
        return (background.Distance - lastSpawnDistance) > distanceToSpawn;
    }
}
