using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    Vector2 rightAttackOffset;

    Collider2D attackCollider;

    private void Start()
    {
        attackCollider = GetComponent<Collider2D>();
        rightAttackOffset = transform.position;
        attackCollider.enabled = false;
    }


    public void AttackRight()
    {
        print("right");
        attackCollider.enabled = true;
        transform.position = rightAttackOffset;
        
        //if (StopAttack())
        {
            
        } 
    }

    public void AttackLeft()
    {
        print("left");
        attackCollider.enabled = true;
        transform.position = new Vector3(rightAttackOffset.x * -1, rightAttackOffset.y);
        StopAttack();
    }

    public void StopAttack()
    {
        attackCollider.enabled = false;
    }
}
