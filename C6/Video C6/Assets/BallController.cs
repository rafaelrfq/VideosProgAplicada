using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    float startingForce = 500f;
    bool hasStarted = false;
    Rigidbody rigidbody;
    Vector3 impulseForce = new Vector3(1, 1);

    void Awake()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(!hasStarted && Input.GetButtonDown("Fire1")) {
            hasStarted = true;
            impulseForce *= startingForce;
            rigidbody.AddForce(impulseForce);
        }
    }
}
