using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public FloatingJoystick joystick;
    Vector3 deltaPos = new Vector3();
    Vector3 movementSpeed = new Vector3(10, 10);
    const float MIN_X = -9, MIN_Y = -4, MAX_X = 9, MAX_Y = 4;

    void Update()
    {
        deltaPos.x = joystick.Horizontal * movementSpeed.x;
        deltaPos.y = joystick.Vertical * movementSpeed.y;
        deltaPos *= Time.deltaTime;

        transform.Translate(deltaPos);

        transform.position = new Vector3(
                                            Mathf.Clamp(transform.position.x, MIN_X, MAX_X),
                                            Mathf.Clamp(transform.position.y, MIN_Y, MAX_Y),
                                            transform.position.z
                                        );
    }
}
