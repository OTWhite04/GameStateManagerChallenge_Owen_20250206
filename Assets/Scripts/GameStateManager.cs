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

    public GameState currentState { get; private set; }
    
    //Stores last state as a string.
    [SerializeField] private string currentStateDebug;
    //Store last value as a string.
    [SerializeField] private string lastStateDebug;

    private void Start()
    {
        ChangeState(GameState.MainMenu_State);
    }
    
    public void ChangeState(GameState newState)
    {
        lastStateDebug = currentState.ToString();

        currentState = newState;

        HandleStateChange(newState);

        currentStateDebug = currentState.ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            ChangeState(GameState.MainMenu_State);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ChangeState(GameState.Pause_State);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            ChangeState(GameState.Gameplay_State);
        }
    }

    private void HandleStateChange(GameState state)
    {
       switch(state)
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
