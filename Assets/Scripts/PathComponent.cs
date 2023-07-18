using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathComponent : MonoBehaviour
{
    public List<Transform> paths;


    public List<Transform> GetListPath()
    {
        return paths;
    }

    private void OnDrawGizmos()
    {
        for (int i = 0; i < paths.Count-1; i++)
        {
            Gizmos.DrawLine(paths[i].position, paths[i+1].position);

        }
    }

}
