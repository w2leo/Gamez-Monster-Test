using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out Wall _))
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        throw new NotImplementedException();
    }

}
