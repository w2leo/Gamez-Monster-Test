using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler SharedInstance;
    [SerializeField] private int amountToPool;
    [SerializeField] GameObject objectToPool;

    private List<GameObject> pooledObjects;

    void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        pooledObjects = new List<GameObject>();
        InitializePooler(amountToPool);
    }

    public void InitializePooler(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject obj = Instantiate(objectToPool).gameObject;
            obj.SetActive(false);
            pooledObjects.Add(obj);
            obj.transform.SetParent(transform);
        }
    }

    public void DisableAllObjects()
    {
        foreach (var item in pooledObjects)
        {
            item.gameObject.SetActive(false);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}
