using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            RemoveEnemy();
        }
    }

    public float health = 1;

    public void RemoveEnemy()
    {
        Debug.Log("Removing Enemy" + gameObject.name);
        Destroy(gameObject);
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider == AttackHitbox)
        {
            Debug.Log("Collision with AttackHitbox. Destroying the game object: " + gameObject.name);
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Collision with something else. Collision object: " + collision.collider.gameObject.name);
        }
    }*/
}
