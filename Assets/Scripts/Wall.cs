using UnityEngine;

public class Wall : MonoBehaviour, IMoveLeft
{
    private IMoveLeft moveInterface;

    public MainGameplay MainGameplay { get; set; }

    private void Start()
    {
        moveInterface = GetComponent<IMoveLeft>();

    }

    private void Update()
    {
        moveInterface.MoveLeft(transform, MainGameplay.GameSpeed * Time.deltaTime);
    }
}
