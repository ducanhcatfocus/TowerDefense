using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseComponent : MonoBehaviour
{
    private Vector3 mousePos;
    public GameObject tower;
 
    void Update()
    {
        mousePos = Input.mousePosition;
        mousePos.z = 10;
        transform.position = Camera.main.ScreenToWorldPoint(mousePos);


        if (Input.GetMouseButtonDown(0))
        {
        
            Instantiate(tower, transform.position, Quaternion.identity);
        }
    }
}
