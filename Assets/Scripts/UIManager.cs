using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
   
    public GameObject mainMenu;
    public GameObject gamePlayUI;
    public GameObject pausedUI;

   public void MainMenuUI()
   {
        DisableAllUIPanels();
        mainMenu.SetActive(true);
   }
    public void GameplayUI()
    {
        DisableAllUIPanels();
        gamePlayUI.SetActive(true);

    }

    public void PausedUI()
    {
        DisableAllUIPanels();
        pausedUI.SetActive(true);

    }


    public void DisableAllUIPanels()
    {
        mainMenu.SetActive(false);
        gamePlayUI.SetActive(false);
        pausedUI.SetActive(false);
    }

}
