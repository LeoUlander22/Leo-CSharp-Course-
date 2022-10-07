using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveCamera : MonoBehaviour
{
    [SerializeField] private TurnManager myManager;
    [SerializeField] private Transform playerCamera1;
    [SerializeField] private Transform playerCamera2;
    [SerializeField] private Vector3 distanceFromThePlayer;
    [SerializeField] private float speed;
    void Update()
    {
        int currentPlayer = myManager.GetCurrentPlayer();

        if (currentPlayer == 1)
        {
            gameObject.transform.position = playerCamera1.position;
        }
        else if (currentPlayer == 2)
        {
            gameObject.transform.position = playerCamera2.position;
        }

        //float step = speed * Time.deltaTime;

    }
}
