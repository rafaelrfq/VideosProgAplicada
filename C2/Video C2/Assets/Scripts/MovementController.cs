using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    Vector2 deltaPos = new Vector2();
    Vector2 movementSpeed = new Vector2(20f, 20f);
    const float LIMIT_MIN_X = -10.25f, LIMIT_MIN_Y = -4.25f, LIMIT_MAX_X = 10.25f, LIMIT_MAX_Y = 4.25f;
    void Update()
    {
        deltaPos.x = Input.GetAxis("Horizontal") * movementSpeed.x;
        deltaPos.y = Input.GetAxis("Vertical") * movementSpeed.y;
        deltaPos *= Time.deltaTime;

        transform.Translate(deltaPos);

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, LIMIT_MIN_X, LIMIT_MAX_X),
            Mathf.Clamp(transform.position.y, LIMIT_MIN_Y, LIMIT_MAX_Y),
            transform.position.z);
    }
}
