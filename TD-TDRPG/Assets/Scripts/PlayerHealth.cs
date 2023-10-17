using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;

    public int heal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Debug.Log("You're supposed to be dead :>" + health);
        }
    }

    public void Heal(int heal)
    {
        health += heal;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
