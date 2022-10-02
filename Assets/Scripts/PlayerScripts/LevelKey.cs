using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelKey : MonoBehaviour
{
    [SerializeField] private GameObject keyIcon;

    public void OnTriggerEnter(Collider other)
    {
        keyIcon.SetActive(true);
    }
}
