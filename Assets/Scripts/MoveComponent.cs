using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveComponent : MonoBehaviour
{
    [SerializeField] float _speed = 2f;
    public List<Transform> path;
    public PathComponent list_path;

    public Vector3 start_position;
    public Vector3 end_position;
    public int currentIndex = 0;
    bool isReach = false;



    private void Start()
    {
 
    }

    private void Update()
    {
        if (!isReach)
        {
            EnemyMovement();

        }
    }

    private void EnemyMovement()
    {
        Vector3 direction = end_position - start_position;
        transform.Translate(_speed * Time.deltaTime * direction.normalized);


     
        if (Vector3.Distance(transform.position, end_position) <= 0.1f)
        {
            currentIndex += 1;

            if (currentIndex == path.Count - 1)
            {
                isReach = true;
                return;
            }

            start_position = path[currentIndex].position;
            end_position = path[currentIndex + 1].position;
        }

    }

    public void Set(float speed)
    {
        _speed = speed;
        path = list_path.GetListPath();
        transform.position = path[0].position;
        start_position = path[currentIndex].position;
        end_position = path[currentIndex + 1].position;
    }
}
