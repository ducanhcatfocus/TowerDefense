using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


public enum EAttack
{
    singleAttack,
    multiAttack,
}
public class AttackComponent : MonoBehaviour
{
    public float dmg;
    public float attackSpeed;
    public EAttack attackType;
    public GameObject projectile;
    public float range;
    private Transform shotPosition;
    private float _timeShoot = 0;
    public bool isEnemy;

    public void SetUp(float dmg, float attackSpeed, float range, Transform shotPosition)
    {
        this.dmg = dmg;
        this.attackSpeed = attackSpeed;
        this.range = range;
        this.shotPosition = shotPosition;
    }


    private void Update()
    {
        if (!isEnemy) return;
        _timeShoot += Time.deltaTime;
        if(_timeShoot > attackSpeed)
        {
            _timeShoot = 0;

            Shoot();
        }
    }

    private void Shoot()
    {
         Instantiate(projectile, shotPosition);
      

        // Tính toán hướng di chuyển từ đạn tới mục tiêu
        //Vector3 directionToTarget = (enemy.position - shotPosition.position).normalized;
        ////xoay goc
        //float angle = Mathf.Atan2(directionToTarget.y, directionToTarget.x) * Mathf.Rad2Deg;
        //projectile.transform.eulerAngles = new Vector3(0, 0, angle);
    }

    public void SetIsEnemy(bool enemy)
    {
        isEnemy = enemy;
    }
}

