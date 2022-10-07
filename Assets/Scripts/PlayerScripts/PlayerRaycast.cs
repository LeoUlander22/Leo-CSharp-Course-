using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    private LineRenderer lineRenderer;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            RaycastHit result;

            //a variable that says whether the raycast hit anything or not.
            bool thereWasHit = Physics.Raycast(transform.position, transform.forward, out result, Mathf.Infinity);

            Vector3 start = transform.position;
            Vector3 end = transform.position + transform.forward * 50f;
            lineRenderer.SetPosition(0, start);
            lineRenderer.SetPosition(1, end);

            //shows the ray.
            Debug.DrawRay(transform.position, transform.forward * 50f, Color.red, 0);

            //if there was a hit on an object, the object hit is fetched and is destroyed.
            if (thereWasHit)
            {
                CharacterController otherCharacter = result.collider.GetComponent<CharacterController>();
                if (otherCharacter != null)
                {
                    Destroy(result.collider.gameObject);
                }

                //Example PickupManager.GetInstance();
            }
        }
    }
    //creates a new color upon being called.
    private Color GetRandomColor()
    {
        Color spicyColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
        return spicyColor;
    }
}
