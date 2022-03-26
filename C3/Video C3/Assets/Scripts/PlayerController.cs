using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speedY = 2f;
    Vector3 deltaPos = new Vector3();
    const float MIN_LIM = -4f, MAX_LIM = 4f;

    void Update()
    {
        deltaPos.y = (Input.touchSupported && Input.touchCount > 0) ? Input.GetTouch(0).position.y * speedY : 0;
        deltaPos.y *= Time.deltaTime;
        transform.Translate(deltaPos);

        transform.position = new Vector3(
            transform.position.x,
            Mathf.Clamp(transform.position.y, MIN_LIM, MAX_LIM),
            transform.position.z);
    }
}
