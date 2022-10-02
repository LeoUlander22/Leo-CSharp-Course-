using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersTurn : MonoBehaviour
{
    private int playerIndex;

    public void SetPlayerTurn(int index)
    {
        playerIndex = index;
    }

    public bool IsplayerTurn()
    {
        return TurnManager.GetInstance().IsItPlayerTurn(playerIndex);
    }
}
