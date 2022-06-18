using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform playerLocation;
    Vector3 fark;
    void Start()
    {
        fark = transform.position - playerLocation.position;
    }

    
    void Update()
    {
        transform.position = playerLocation.position + fark; 
    }
}
