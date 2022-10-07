using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWeapon : MonoBehaviour
{
  [SerializeField] private GameObject projectilePrefab;
  [SerializeField] private Transform shootingStartPosition;
  //[SerializeField] private TrajectoryLine lineRenderer;

    private void Update()
    {
        //bool IsPlayerTurn;
        Vector3 force = shootingStartPosition.forward;
        if (Input.GetKeyDown(KeyCode.V))
        {
            GameObject newProjectile = Instantiate(projectilePrefab);
            newProjectile.transform.position = shootingStartPosition.position;
            newProjectile.GetComponent<Projectile>().Initialize(force);
        }
    }
}
