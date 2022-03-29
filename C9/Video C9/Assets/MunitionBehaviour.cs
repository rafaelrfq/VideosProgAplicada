using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunitionBehaviour : MonoBehaviour
{
    Vector3 currentSpeed = new Vector3();
    Vector3 deltaPos = new Vector3();
    bool shot;

    void Update()
    {
        if (!shot)
            return;
        deltaPos = currentSpeed * Time.deltaTime + Physics.gravity * Mathf.Pow(Time.deltaTime, 2) / 2;
        transform.Translate(deltaPos);
        currentSpeed += Physics.gravity * Time.deltaTime;
    }

    public void Shoot(Vector3 startingSpeed, float shootingAngle)
    {
        currentSpeed = new Vector3(startingSpeed.x * Mathf.Cos(shootingAngle), startingSpeed.y * Mathf.Sin(shootingAngle));
        shot = true;
    }
}
