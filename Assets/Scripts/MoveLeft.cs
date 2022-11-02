using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float moveSpeed = 10f;
    private PlayerMoveController playerController;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerMoveController>();
    }

    void Update()
    {
        if (!playerController.GameIsOver)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
    }



    private void UpdateSpeed()
    { 
    }
}
