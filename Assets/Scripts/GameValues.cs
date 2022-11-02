using UnityEngine;

public static class GameValues 
{
    public const float yBound = 8f;
    public static float basicMoveLeftSpeed = 10f;
    public static float basicPlayerSpeed = 5f;
    public static bool gameIsActive = true;

    public static Vector2 GetRandomPosition(float minX, float maxX, float minY, float maxY)
    {
        float xPosition = Random.Range(minX, maxX);
        float yPosition = Random.Range(minY, maxY);
        return new Vector2(xPosition, yPosition);
    }

    public static Vector2 GetRandomPosition(float xValue, float yBound)
    {
        return GetRandomPosition(xValue, xValue, -yBound, yBound);
    }

}
