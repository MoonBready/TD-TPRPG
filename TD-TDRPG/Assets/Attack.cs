using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Collider2D attackCollider;

    public float damage = 3;

    Vector2 rightAttackOffset;


    private void Start()
    {
        rightAttackOffset = transform.localPosition;
    }


    public void AttackRight()
    {
        attackCollider.enabled = true;
        transform.localPosition = rightAttackOffset;
        
        /*if (StopAttack())
        {
            
        }*/
    }

    public void AttackLeft()
    {
        attackCollider.enabled = true;
        transform.localPosition = new Vector3(rightAttackOffset.x * -1, rightAttackOffset.y);
    }

    public void StopAttack()
    {
        attackCollider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D attackCollider)
    {
        Debug.Log("Collision Detected with: " + attackCollider.gameObject.name);

        if(attackCollider.tag == "Enemy")
        {
            Enemy enemy = attackCollider.GetComponent<Enemy>();
            Destructible destructible = attackCollider.GetComponent<Destructible>();

            if(enemy && destructible != null)
            {
                enemy.TakeDamage(damage);
                destructible.TakeDamage(damage);
                Debug.Log("Damage Applied to enemy: " + enemy.gameObject.name + "Current health" +  enemy.health);
            }
        }
    }
}
