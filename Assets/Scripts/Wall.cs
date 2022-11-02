using UnityEngine;

public class Wall : MonoBehaviour, IMoveLeft
{
    protected IMoveLeft moveInterface;

    protected virtual void Start()
    {
        moveInterface = GetComponent<IMoveLeft>();
    }

    protected void Update()
    {
        moveInterface.MoveLeft(transform, GameValues.moveLeftSpeed * Time.deltaTime);      
    }
}
