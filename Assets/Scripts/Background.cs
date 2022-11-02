using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]

public class Background : MonoBehaviour, IMoveLeft
{
    [SerializeField] private MainGameplay gameplay;
    private Vector3 startPosition;
    private float repeatWidth;
    private IMoveLeft moveInterface;
    
    private void Start()
    {
        startPosition = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
        moveInterface = GetComponent<IMoveLeft>();
    }

    private void Update()
    {
        float deltaX = gameplay.GameSpeed * Time.deltaTime;
        moveInterface.MoveLeft(transform, deltaX);
        
       
        if (transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}
