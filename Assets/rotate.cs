
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class rotate : MonoBehaviour
{
    public Vector2 moveValue;
    public float speed;

    void Update()
    {
        transform.Rotate(0, Time.deltaTime * speed,  0, Space.Self);
        
    }

   
}
