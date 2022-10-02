using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMovement : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    
    void Update()
    {
        //create a Raycast from the camera, giving the agent a point to move toward.
       if (Input.GetMouseButtonDown(0))
        {
            RaycastHit result;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out result, 100.0f))
            {
                agent.SetDestination(result.point);
            }
        }
    }
}
