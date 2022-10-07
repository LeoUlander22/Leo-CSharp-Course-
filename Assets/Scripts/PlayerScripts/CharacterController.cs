using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Rigidbody characterBody;
    [SerializeField] private PlayersTurn currentPlayerTurn;
    [SerializeField] private float f_speed = 2f;
    [SerializeField] private int playerIndex;
    
    void Update()
    {
        //Fetches the current player index and lets them move.
        if (TurnManager.GetInstance().IsItPlayerTurn(playerIndex))
        {
            //theCamera = GetComponent<Camera>(Camera.main);
            if (Input.GetAxis("Horizontal") != 0)
            {
                transform.Translate(transform.right* f_speed * Time.deltaTime * Input.GetAxis("Horizontal"));
            }

            if (Input.GetAxis("Vertical") != 0)
            {
                transform.Translate(transform.forward* f_speed * Time.deltaTime * Input.GetAxis("Vertical"));
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        }


    }
    //Sees if the player has landed, this can be used to Change turn, only when the player is not moving.
    private bool IsTouchingFloor()
    {
        RaycastHit localHit;
        return Physics.SphereCast(transform.position, 0.15f, -transform.up, out localHit, 1f);
    }
    
    //Adds force upward on jump, gravity does the rest.
    private void Jump()
    {
        characterBody.AddForce(Vector3.up * 100f);
    }
    //Can be used to change the colour of the player upon taking damage?
    private void ColourChange()
    {

    }
}
