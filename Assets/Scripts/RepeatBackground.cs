using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour, IMoveLeft
{
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
        moveInterface.MoveLeft(transform, GameValues.moveLeftSpeed * Time.deltaTime);
        if (transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}
