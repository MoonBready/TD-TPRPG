using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public float Health
    {
        set
        {
            health = value;
            if (health <= 0)
            {
                RemoveEnemy();
            }
        }
        get
        {
            return health;
        }
    }

    public float health = 1;

    public void RemoveEnemy()
    {
        Destroy(gameObject);
    }
}
