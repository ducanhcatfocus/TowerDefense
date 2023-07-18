using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum EEnemy
{
    normal,boss
}
public class Enemy : MonoBehaviour
{
    

    public EnemySO enemySO;
    public float enemyHp;

    public MoveComponent movement;

    private void Start()
    {
        enemyHp = enemySO.hp;
        StartMove();

    }

    private void StartMove()
    {
        movement.Set(enemySO.speed);
    }


    public void TakeDamage(float dmg)
    {
        enemyHp -= dmg;
        if (enemyHp <= 0)
        {
            Destroy(gameObject);

        }
    }
        
}
