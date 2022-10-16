using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //Leo Ulander
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody projectileBody;
    [SerializeField] private GameObject damageImdicatorPrefab;
    [SerializeField] private float lifeTime = 0f;

    private bool isActive;

    public void Initialize(Vector3 direction)
    {
        isActive = true;
        //Adds a force to the projectile as soon as it exists.
        projectileBody.AddForce(direction);
    }

    void Update()
    {
        if (isActive)
        {
            //Adding the forward position of the projectile and the speed makes the object move in MovePosition.
            projectileBody.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);

            lifeTime += Time.deltaTime;
            /* or this one (movement with the transform), both are ok. Which doesn't work with collision and movement we expect of the bullets /Leo
            transform.Translate(transform.forward * speed * Time.deltaTime);
            */
        }
        //if 3 "seconds" have passed the object is destroyed.
        if (lifeTime >= 3f)
            Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //If the object collides it is also destroyed.
            Destroy(gameObject);


        //It will damage the player it hits, otherwise be destroyed on contact.
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<HealthPoints>().TakeDamage(20);
            Destroy(gameObject);
        }

        //Code for creating an object marking the impact point for the collision.
        //GameObject damageIndicator = Instantiate(damageImdicatorPrefab);
        //damageIndicator.transform.position = collision.GetContact(0).point;
    }
}
