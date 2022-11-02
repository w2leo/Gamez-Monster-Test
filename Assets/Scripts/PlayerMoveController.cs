using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    public bool GameIsOver;

    [SerializeField] private float moveSpeed;
    private float yBoundAbs = 5f;

    private void Update()
    {
        MovePlayer(GetDirection(Input.GetKey(KeyCode.UpArrow)));
    }

    private void MovePlayer(Vector2 direction)
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime);
        CheckYBound();
    }

    private Vector2 GetDirection(bool upButton)
    {
        return upButton == true ? Vector2.up : Vector2.down;
    }

    private void CheckYBound()
    {
        if (Mathf.Abs(transform.position.y) > yBoundAbs)
        {
            float ySign = Mathf.Sign(transform.position.y);
            transform.position = new Vector2(transform.position.x, ySign * yBoundAbs);
        }
    }
}
