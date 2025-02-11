using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
   
    public GameObject mainMenu;
    public GameObject gamePlayUI;
    public GameObject pausedUI;

    //Sets Main Menu to active.
   public void MainMenuUI()
   {
        DisableAllUIPanels();
        mainMenu.SetActive(true);
   }
   //Sets gameplay UI to active.
    public void GameplayUI()
    {
        DisableAllUIPanels();
        gamePlayUI.SetActive(true);

    }
    //Sets Paused UI to active.
    public void PausedUI()
    {
        DisableAllUIPanels();
        pausedUI.SetActive(true);

    }

    //Disables all menus to start.
    public void DisableAllUIPanels()
    {
        mainMenu.SetActive(false);
        gamePlayUI.SetActive(false);
        pausedUI.SetActive(false);
    }

}
