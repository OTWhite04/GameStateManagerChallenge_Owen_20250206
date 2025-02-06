using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{

    public enum GameState
    {
        MainMenu_State,
        Gameplay_State,
        Pause_State
    }

    public GameState gameState;
    
    private void Update()
    {
       switch(gameState)
       {
            case GameState.MainMenu_State:
            {
                    Debug.Log("Main Menu State");
                    break;
            }
            case GameState.Gameplay_State:
            {
                    Debug.Log("In Gameplay State");
                    break;
            }
            case GameState.Pause_State:
            {
                    Debug.Log("In Paused State");
                    break;
            }
       
       }
    }
}
