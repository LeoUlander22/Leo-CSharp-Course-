using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;

public class PlayerFiringBehaviour : MonoBehaviour
{
    //Leo Ulander

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootingStartPosition;
    [SerializeField] public int _ammoCount = 5;
    [SerializeField] AudioClip emptyClipSound;
    [SerializeField] AudioClip firingSound;
    [SerializeField] private int playerIndex;
    //public InputAction fireAction; Is an uneccesarry part of the "InputEditor. Since it's actually separate to InputSystem, despite being the reference in Unity's Manual.

    //This, whatever a IEnumerator is, Pauses the "Getting" function and refills the ammo count.
    private IEnumerator Reload()
    {
        Debug.Log("Started Reload Coroutine" + Time.time);

        yield return new WaitForSeconds(1);

        Debug.Log("Ending Reload Coroutine" + Time.time);
        _ammoCount = 5;
    }
    //Originally OnFire, a InputSystem function.
    private void Update()
    {
        if (TurnManager.GetInstance().IsItPlayerTurn(playerIndex))
        { 
            Vector3 force = shootingStartPosition.forward;
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                //If there is a bullet available, one is instatiated, is given a specific force and the _ammoCount is reduced by 1.
                if (_ammoCount > 0)
                {
                    GameObject newProjectile = Instantiate(bulletPrefab);
                    newProjectile.transform.position = shootingStartPosition.position;
                    newProjectile.transform.localRotation = shootingStartPosition.rotation;
                    newProjectile.GetComponent<Projectile>().Initialize(force);
                    AudioSource.PlayClipAtPoint(firingSound, transform.position);
                    AmmoCount(-1);
                }
                else if (_ammoCount <= 0)
                {
                    AudioSource.PlayClipAtPoint(emptyClipSound, transform.position);
                    //Calls the IEnumerator Reload and forces this "else if" to wait for it.
                    StartCoroutine(Reload());
                }
                else
                    return;
                //else if there is a bug/lapse in the execution of the _ammoCount, the Update can try again.
            }
        }
    }

    public void AmmoCount(int amountBullets)
    {
        _ammoCount += amountBullets;
    }
}
