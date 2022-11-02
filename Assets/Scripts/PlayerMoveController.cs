using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    public bool GameIsOver;
    [SerializeField] private float moveSpeed;

    private void Update()
    {
        MovePlayer(Input.GetKey(KeyCode.UpArrow));
    }

    private void MovePlayer(bool upButton)
    {
        Vector2 direction;
        direction = Vector2.down;
        if (upButton)
        {
            direction = Vector2.up;
        }
        
        transform.Translate(direction * moveSpeed * Time.deltaTime);   
    }

}
