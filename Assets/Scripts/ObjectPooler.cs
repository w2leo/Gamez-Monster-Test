using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler SharedInstance;

    
    [SerializeField] GameObject objectToPool;

    private List<GameObject> pooledObjects;
    private int amountToPool;

    void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        pooledObjects = new List<GameObject>();
        InitializePooler(10);
    }

    public void InitializePooler(int amount)
    {
        ClearPool();
        amountToPool = amount;

        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(objectToPool).gameObject;
            obj.SetActive(false);
            pooledObjects.Add(obj);
            obj.transform.SetParent(transform);
        }
    }

    private void ClearPool()
    {
        if (pooledObjects.Count > 0)
        {
            foreach (var item in pooledObjects)
            {
                Destroy(item.gameObject);
            }
            pooledObjects.Clear();
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
