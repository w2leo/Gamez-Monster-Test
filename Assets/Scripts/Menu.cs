using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private MenuType menuType;

    public MenuType MenuType => menuType;
}
