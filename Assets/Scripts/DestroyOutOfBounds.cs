using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float xBound = -30f;
    
    void Update()
    {
        if (transform.position.x < xBound)
        {
            gameObject.SetActive(false);
        }
    }
}
