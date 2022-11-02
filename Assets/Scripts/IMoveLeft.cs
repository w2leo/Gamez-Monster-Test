using UnityEngine;

public interface IMoveLeft
{
    public void MoveLeft(Transform transform, float moveSpeed)
    {
        transform.Translate(Vector3.left * moveSpeed);
    }
}

