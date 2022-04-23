using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public Rigidbody goal;
    public float moveSpeedCube,dirZ,dirX;

    private void Start()
    { 
        moveSpeedCube = 10f;
        goal = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeedCube;
        dirZ = Input.GetAxis("Vertical") * moveSpeedCube;
    }

    private void LateUpdate()
    {
      goal.velocity = new Vector3(dirX, goal.velocity.y, dirZ);
    }
}

