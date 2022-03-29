using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject munition;
    Vector3 startingSpeed;
    const float SCALAR_SPEED = 20f;
    float currentAngle, deltaY, deltaX;
    Vector3 userInput = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        startingSpeed = new Vector3(SCALAR_SPEED, SCALAR_SPEED);
    }

    // Update is called once per frame
    void Update()
    {
        userInput = Camera.main.ScreenToWorldPoint(Input.touchSupported && Input.touchCount > 0 ? (Vector3)Input.GetTouch(0).position : Input.mousePosition);
        deltaY = userInput.y - transform.position.y;
        deltaX = userInput.x - transform.position.x;

        currentAngle = Mathf.Atan(deltaY / deltaX);
        Debug.Log(currentAngle * Mathf.Rad2Deg);

        // Trigger
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(munition, transform.position, Quaternion.identity).GetComponent<MunitionBehaviour>().Shoot(startingSpeed, currentAngle);
        }
    }
}
