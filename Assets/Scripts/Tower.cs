using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum ETower
{
    singleTarget,
    multiTarget,
}
public class Tower : MonoBehaviour
{
    public TowerSO towerSO;
    public AttackComponent attackComponent;
    public Transform shotPosition;


    private void Start()
    {
        attackComponent.SetUp(towerSO.dmg, towerSO.speedAttack, towerSO.range, shotPosition);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(shotPosition.position, towerSO.range);
    }


}
