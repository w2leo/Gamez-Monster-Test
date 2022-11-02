using UnityEngine;

public static class RandomPosition 
{
    public static float yBound = 7.5f;

    private static Vector2 GetRandomPosition(float minX, float maxX, float minY, float maxY)
    {
        float xPosition = Random.Range(minX, maxX);
        float yPosition = Random.Range(minY, maxY);
        return new Vector2(xPosition, yPosition);
    }

    private static Vector2 GetRandomPosition(float xValue, float yBound)
    {
        return GetRandomPosition(xValue, xValue, -yBound, yBound);
    }

    public static Vector2 GetRandomPosition(float xValue)
    {
        return GetRandomPosition(xValue, xValue, -yBound, yBound);
    }
}
