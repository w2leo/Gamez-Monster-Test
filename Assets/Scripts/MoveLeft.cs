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
        Move(gameplay.GameSpeed * Time.deltaTime);
    }

    public void Move(float speed)
    {
        transform.Translate(Vector2.left * speed);    
    }
}
