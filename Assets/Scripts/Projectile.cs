using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody projectileBody;
    //[SerializeField] private GameObject damageIndicatorPrefab;
    private bool isActive;

    public void Initialize()
    {
        isActive = true;
        //projectileBody.AddForce((transform.forward + transform.up) * 100f);
    }

    // The projectile travels forward automatically.
    void Update()
    {
        if (isActive)
        {
            //projectileBody.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
            transform.Translate(transform.forward * speed * Time.deltaTime);
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collisionObject = collision.gameObject;
        Destroy(collisionObject);
        TurnManager.GetInstance().ChangeTurn();
        //GameObject damageIndicator = Instantiate(damageIndicatorPrefab);
        //damageIndicator.transform.position = transform.position;
    }
}
