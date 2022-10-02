using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayerInput : MonoBehaviour
{
    [SerializeField] private ActivePlayerManager myManager;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float walkingSpeed;
    
    void Update()
    {
        if(Input.GetAxis("Horizontal") != 0)
        {
            //ActivePlayer currentPlayer = myManager.GetCurrentPlayer();
            //currentPlayer.transform.Rotate(Vector3.up * walkingSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World);
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            //ActivePlayer currentPlayer = myManager.GetCurrentPlayer();
            //currentPlayer.transform.Translate(Vector3.forward * walkingSpeed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);
        }
    }
}
