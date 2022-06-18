using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPoint : MonoBehaviour
{
    
    public GameObject lastCube;
    
    void Start()
    { 
        for(int i = 0; i < 25; i++)
        {
            CubeCreate();
            i++;
        }
    }
    public void CubeCreate()
    {
        Vector3 direction;
       
        if(Random.Range(0,2) == 0)
        {
            direction = Vector3.left;
        }
        else
        {
            direction = Vector3.forward;
        }

        lastCube = Instantiate(lastCube, lastCube.transform.position + direction, lastCube.transform.rotation);
    }
}
