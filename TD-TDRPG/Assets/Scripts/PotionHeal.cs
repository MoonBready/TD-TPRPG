using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionHeal : MonoBehaviour
{
    public int heal;
    public PlayerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.Heal(5);
            Debug.Log("CurrentHealth = " + playerHealth.health);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
