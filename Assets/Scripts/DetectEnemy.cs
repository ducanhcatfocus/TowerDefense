using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemy : MonoBehaviour
  
{

    public AttackComponent _AttackComponent;
    public MoveArrowComponent _MoveArrowComponent;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy")){
  
            _MoveArrowComponent.SetEnemy(collision.transform);

            _AttackComponent.SetIsEnemy(true);

        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {

            _MoveArrowComponent.SetEnemy(collision.transform);

            _AttackComponent.SetIsEnemy(true);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            _MoveArrowComponent.SetEnemy(null);

            _AttackComponent.SetIsEnemy(false);
        }
    }
}
