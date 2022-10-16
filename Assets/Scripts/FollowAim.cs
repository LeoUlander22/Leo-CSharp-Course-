using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAim : MonoBehaviour
{
    //Leo Ulander
    [SerializeField] Transform followTarget;
    // Update is called once per frame
    void Update()
    {
        transform.position = followTarget.position - new Vector3(0, -4, 5f);
        transform.LookAt(followTarget);
    }
}
