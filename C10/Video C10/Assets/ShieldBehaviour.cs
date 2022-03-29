using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBehaviour : MonoBehaviour
{
    GameObject centerObject;
    Vector3 currentPosition = new Vector3(), angle, currentSpeed = new Vector3();
    float currentDistance, scalarAcceleration = 2f, shootingTime;

    void Update()
    {
        angle = currentSpeed * (Time.time - shootingTime) / currentDistance;

        currentPosition.x = centerObject.transform.position.x + currentDistance * Mathf.Cos(angle.x);
        currentPosition.y = centerObject.transform.position.y + currentDistance * Mathf.Sin(angle.y);
        transform.position = currentPosition;

        currentSpeed.x += scalarAcceleration * Time.deltaTime;
        currentSpeed.y += scalarAcceleration * Time.deltaTime;
    }

    public void Shoot(GameObject center, float distance)
    {
        centerObject = center;
        currentDistance = distance;
        shootingTime = Time.time;
    }
}
