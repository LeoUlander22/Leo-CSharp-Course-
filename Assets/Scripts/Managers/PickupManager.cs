using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupManager : MonoBehaviour
{
    private static PickupManager instance;
    [SerializeField] GameObject pickupPrefab;
    //If there is more than one Manager, delete this gameObject.

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
          
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Create a callable reference???? Why?
    public static PickupManager GetInstance()
    {
        return instance;
    }

    // Instatiate new object upon request.
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newPickup = Instantiate(pickupPrefab);
            newPickup.transform.position = new Vector3(Random.Range(0f, 5f), 1f, Random.Range(0f, 5f));
        }
    }
}
