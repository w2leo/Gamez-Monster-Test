using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] List<Menu> menusList;

    private void Start()
    {
        SetMenu(MenuType.MainMenu);
        MainGameplay.NotifyGameState += GameStateHandler;
    }

    private void GameStateHandler(bool state)
    {
        MenuType currenMenu = state ? MenuType.GameUI : MenuType.EndMenu;
        SetMenu(currenMenu);
    }

    private void SetMenu(MenuType menuType)
    {
        foreach (var menu in menusList)
        {
            menu.gameObject.SetActive(menu.MenuType == menuType);
        }
    }
}
