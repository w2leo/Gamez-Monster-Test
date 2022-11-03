using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum MenuType
{
    MainMenu,
    EndMenu,
    GameUI
}
public class MenuController : MonoBehaviour
{
    [SerializeField] List<Menu> menusList;

    public void SetMenu(MenuType menuType)
    {
        foreach (var menu in menusList)
        {
            menu.gameObject.SetActive(menu.MenuType == menuType);
        }
    }
}
