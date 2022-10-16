using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Leo Ulander

    [SerializeField] private Rigidbody characterBody;
    [SerializeField] private float f_Speed = 2f;
    [SerializeField] private float r_Speed = 1f;
    [SerializeField] private int playerIndex;
    //private float rotationSpeed = 0f;
    
    void Update()
    {
        //Fetches the current player index and lets them move.
        if (TurnManager.GetInstance().IsItPlayerTurn(playerIndex))
        {
            //rotationSpeed -= Input.GetAxis("Horizontal") * r_Speed;
            //theCamera = GetComponent<Camera>(Camera.main);
            if (Input.GetAxis("Horizontal") != 0)
            {
                /*This code somehow rotates the player while making the Forward direction wrong hmmm...
                transform.Rotate(transform.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));*/
                transform.Rotate(transform.up, Input.GetAxis("Horizontal") * r_Speed * Time.deltaTime);
                //transform.eulerAngles = new Vector3(0.0f, rotationSpeed * Time.deltaTime, 0.0f);
            }

            if (Input.GetAxis("Vertical") != 0)
            {
                //transform.Translate(transform.forward * Input.GetAxis("Vertical"));
                //perhaps its not the Rotation thats wrong, but the forward thing...
                transform.Translate(Vector3.forward * f_Speed * Time.deltaTime * Input.GetAxis("Vertical"), Space.Self);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        }


    }
    
    
    //Adds force upward on jump, gravity does the rest.
    private void Jump()
    {
        characterBody.AddForce(Vector3.up * 350f);
    }
    //Sees if the player has landed, this could be used to Change turn, only when the player is not moving.
    //private bool IsTouchingFloor()
    //{
    //    RaycastHit localHit;
    //    return Physics.SphereCast(transform.position, 0.15f, -transform.up, out localHit, 1f);
    //}

    //Add function to change the colour of the player upon taking damage?
}
