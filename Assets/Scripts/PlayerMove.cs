using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private void Update()
    {
        MovePlayer(GetDirection(Input.GetKey(KeyCode.UpArrow)), GameValues.basicPlayerSpeed);
    }

    private void MovePlayer(Vector2 direction, float moveSpeed)
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
        if (Mathf.Abs(transform.position.y) > GameValues.yBound)
        {
            float ySign = Mathf.Sign(transform.position.y);
            transform.position = new Vector2(transform.position.x, ySign * GameValues.yBound);
        }
    }
}
