using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HealthPoints : MonoBehaviour
{
    [SerializeField] int playerHealth = 100;
    [SerializeField] AudioClip playerHurt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        Debug.Log("hit the other player");
        playerHealth -= damage;
        AudioSource.PlayClipAtPoint(playerHurt, transform.position);
        if (playerHealth <= 0)
        {
            SceneManager.LoadScene("SampleScene");
            //TurnManager.instance.EnemyKilled();
            //Destroy(gameObject);
        }
    }
}
