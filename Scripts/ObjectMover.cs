using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectMover : MonoBehaviour
{
    public float Speed;
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 amountToMove = new Vector3(Speed, 0, 0);
        transform.Translate(amountToMove);
    }
 
}
