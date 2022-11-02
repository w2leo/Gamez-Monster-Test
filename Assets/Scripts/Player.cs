using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float attemptTime;

    private void Start()
    {
        attemptTime = 0;
    }

    private void Update()
    {
        attemptTime += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Wall _))
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        Debug.Log($"Game Over. Your time = {attemptTime:0.0} seconds");
        throw new NotImplementedException();
    }

}
