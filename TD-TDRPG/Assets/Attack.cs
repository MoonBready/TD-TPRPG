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
    }


    public void AttackRight()
    {
        print("right");
        attackCollider.enabled = true;
        transform.position = rightAttackOffset;
    }

    public void AttackLeft()
    {
        print("left");
        attackCollider.enabled = true;
        transform.position = new Vector3(rightAttackOffset.x * -1, rightAttackOffset.y);
    }

    public void StopAttack()
    {
        attackCollider.enabled = false;
    }
}
