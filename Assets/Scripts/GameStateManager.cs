using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public GameManager gameManager;

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
        ChangeStateToMainMenu();
    }
    
    public void ChangeState(GameState newState)
    {
        lastStateDebug = currentState.ToString();

        currentState = newState;

        HandleStateChange(newState);

        currentStateDebug = currentState.ToString();
    }

    public void ChangeStateToMainMenu()
    {
        ChangeState(GameState.MainMenu_State);
        gameManager.uIManager.MainMenuUI();
    }
    
    public void Pause()
    {

    }

    public void Resume()
    {

    }
    public void ChangeStateToGameplay()
    {
        ChangeState(GameState.Gameplay_State);
        gameManager.uIManager.GameplayUI();
    }


    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape) && currentState == GameState.Pause_State)
        {
            Debug.Log("Changed to Pause");
            Pause();
        }

       else if (Input.GetKeyDown(KeyCode.Escape) && currentState == GameState.Pause_State)
        {
            Debug.Log("Changed to Gameplay");
            Resume();
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
                    Time.timeScale = 1.0f;
                    break;
            }
            case GameState.Pause_State:
            {
                    Debug.Log("In Paused State");
                    Time.timeScale = 0.0f;
                    break;
            }
       
       }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
