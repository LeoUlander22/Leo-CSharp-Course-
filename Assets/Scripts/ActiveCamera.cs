using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveCamera : MonoBehaviour
{
    [SerializeField] private ActivePlayerManager myManager;
    [SerializeField] private Vector3 distanceFromThePlayer;
    [SerializeField] private float speed;
    void Update()
    {
        //Vector3 targetPosition = myManager.GetCurrentPlayer().transform.position + distanceFromThePlayer;

        float step = speed * Time.deltaTime;

    }
}
