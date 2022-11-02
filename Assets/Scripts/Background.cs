using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]

public class Background : MonoBehaviour, IMoveLeft
{
    private Vector3 startPosition;
    private float repeatWidth;
    private IMoveLeft moveInterface;
    private float distance;

    public float Distance => distance;
    
    private void Start()
    {
        startPosition = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
        moveInterface = GetComponent<IMoveLeft>();
    }

    private void Update()
    {
        float deltaX = GameValues.moveLeftSpeed * Time.deltaTime;
        moveInterface.MoveLeft(transform, deltaX);
        distance += deltaX;
       
        if (transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}
