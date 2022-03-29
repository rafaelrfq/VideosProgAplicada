using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    Vector3 currentPosition = new Vector3();
    const float MAX_Y = 8f, SPEED_Y = 15f;
    void Start()
    {
        
    }

    void Update()
    {
        currentPosition.y = -4 + Mathf.PingPong(Time.time * SPEED_Y, MAX_Y);
        transform.position = currentPosition;
    }
}
