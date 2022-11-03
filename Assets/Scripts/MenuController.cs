using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] List<Menu> menusList;

    private void Start()
    {
        SetMenu(MenuType.MainMenu);
    }

    public void SetMenu(MenuType menuType)
    {
        foreach (var menu in menusList)
        {
            menu.gameObject.SetActive(menu.MenuType == menuType);
        }
    }
}
