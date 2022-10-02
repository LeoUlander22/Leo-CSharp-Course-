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
        //fetches the current player index and lets them move.
        if (TurnManager.GetInstance().IsItPlayerTurn(playerIndex))
        {
            if (Input.GetAxis("Horizontal") != 0)
            {
                transform.Translate(transform.right* f_speed * Time.deltaTime * Input.GetAxis("Horizontal"));
            }

            if (Input.GetAxis("Vertical") != 0)
            {
                transform.Translate(transform.forward* f_speed * Time.deltaTime * Input.GetAxis("Vertical"));
            }

            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    Jump();
            //}
        }


    }
    //sees if the object hitöoasiudnasodm wtf is this?
    private bool IsTouchingFloor()
    {
        RaycastHit localHit;
        return Physics.SphereCast(transform.position, 0.15f, -transform.up, out localHit, 1f);
    }
    

    private void Jump()
    {
        characterBody.AddForce(Vector3.up * 100f);
    }
    private void ColourChange()
    {

    }
}
