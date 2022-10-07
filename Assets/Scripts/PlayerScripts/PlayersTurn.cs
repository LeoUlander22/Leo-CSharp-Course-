using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersTurn : MonoBehaviour
{
    [SerializeField] private int playerIndex;

    public void SetPlayerTurn(int index)
    {
        playerIndex = index;
    }

    //Checks the if the current player matches the current Index.
    public bool IsplayerTurn()
    {
        return TurnManager.GetInstance().IsItPlayerTurn(playerIndex);
    }
}
