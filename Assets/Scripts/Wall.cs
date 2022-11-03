using UnityEngine;

public class Wall : MonoBehaviour
{
    private int damage = 1;
    private float xBound = -30f;

    public int GetDamage()
    {
        return damage;
    }

    void Update()
    {
        if (transform.position.x < xBound)
        {
            gameObject.SetActive(false);
        }
    }
}
