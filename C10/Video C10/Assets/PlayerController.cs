using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Shield;
    const float shieldDistance = 2f;

    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
            Instantiate(Shield, transform.position, Quaternion.identity).GetComponent<ShieldBehaviour>().Shoot(gameObject, shieldDistance);
        }
    }
}
