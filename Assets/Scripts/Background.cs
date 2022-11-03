using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]

public class Background : MonoBehaviour
{
    //[SerializeField] private MainGameplay gameplay;
    private Vector3 startPosition;
    private float repeatWidth;
    
    private void Start()
    {
        startPosition = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    private void Update()
    {
        //float deltaX = gameplay.GameSpeed * Time.deltaTime;      
       
        if (transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}
