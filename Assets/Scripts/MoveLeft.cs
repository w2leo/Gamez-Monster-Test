using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private MainGameplay gameplay;

    private void Start()
    {
        gameplay = FindObjectOfType<MainGameplay>();
    }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.Translate(Vector3.left * gameplay.GameSpeed * Time.deltaTime);
    }
}
