using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMoveLeft 
{
    public void MoveLeft(Transform transform, float moveSpeed)
    {
        if (GameValues.gameIsActive)
        {
            transform.Translate(Vector3.left * moveSpeed);
        }
    }
}

