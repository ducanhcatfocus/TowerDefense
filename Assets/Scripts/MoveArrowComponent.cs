using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MoveArrowComponent : MonoBehaviour
{
    public float speed;
    public float timeToDestroy;
    private float timeDestroyCurrent;
    public Transform enemy;
   



    private void Update()
    {

        if (enemy == null)
        {


            return;
        }

        timeDestroyCurrent += Time.deltaTime;
        if(timeDestroyCurrent > timeToDestroy)
        {
            Destroy(gameObject);
            return;
        }

        // Tính toán hướng di chuyển từ đạn tới mục tiêu
        Vector3 directionToTarget = (enemy.position - transform.position).normalized;
     
        //xoay goc
        float angle = Mathf.Atan2(directionToTarget.y, directionToTarget.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle);
        transform.position += speed * Time.deltaTime * transform.right;


        float distanceToTarget = Vector3.Distance(transform.position, enemy.position);
        if (distanceToTarget <= 0.1f)
        {
            Enemy targetController = enemy.GetComponent<Enemy>();
            if (targetController != null)
            {
                targetController.TakeDamage(10);
            }

            Destroy(gameObject);
        }

    }

    public void SetEnemy(Transform target)
    {
        enemy = target;
    }
}

