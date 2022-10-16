using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    //Leo Ulander
    public static TurnManager instance;
    [SerializeField] private PlayersTurn playerOne;
    [SerializeField] private PlayersTurn playerTwo;
    [SerializeField] private float timeBetweenTurns;
    [SerializeField] private float turnDuration;

    [SerializeField] private int currentPlayerIndex;
    private bool waitingForNextTurn;
    private float turnDelay;
    private float currentTurnTimer;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            currentPlayerIndex = 1;
            playerOne.SetPlayerTurn(1);
            playerTwo.SetPlayerTurn(2);
        }
    }
    private void Start()
    {
        
    }

    //Checks if a timer has reached the point to switch Player.
    private void Update()
    {
        currentTurnTimer += Time.deltaTime;

        if (currentTurnTimer >= turnDuration)
        {
            ChangeTurn();
            currentTurnTimer = 0;
        }
        
    }

    //Returns the current playerIndex.
    public int GetCurrentPlayer()
    {
        return currentPlayerIndex;
    }

    //Returns true if the player index matches the currentPlayer.
    public bool IsItPlayerTurn(int playerIndex)
    {
        //should be toggled somewhere. it is unused.
        if (waitingForNextTurn)
        {
            return false;
        }
        return playerIndex == currentPlayerIndex;
    }

    public static TurnManager GetInstance()
    {
        return instance;
    }

    //Changes the currentPlayerIndex to the other player.
    public void ChangeTurn()
    {
        if(currentPlayerIndex == 1)
        {
            currentPlayerIndex = 2;
        }
        else if (currentPlayerIndex == 2)
        {
            currentPlayerIndex = 1;
        }
    }
    public void EnemyKilled()
    {

    }
}
