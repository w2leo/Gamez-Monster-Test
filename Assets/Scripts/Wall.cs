using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Wall : MonoBehaviour, IMoveLeft
{
    private IMoveLeft moveInterface;

    private void Start()
    {
        moveInterface = GetComponent<IMoveLeft>();
    }

    private void Update()
    {
        moveInterface.MoveLeft(transform, GameValues.moveLeftSpeed * Time.deltaTime);      
    }
}