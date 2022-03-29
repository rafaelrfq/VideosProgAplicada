using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInstantiator : MonoBehaviour
{
    public GameObject redCube, blueCube, greenCube, yellowCube;
    Vector3 startingPosition = new Vector3(0, 7.5f);
    float nextTime;
    const float MIN_TIME = 0.2f, MAX_TIME = 1.5f, MIN_X = -5f, MAX_X = 5f;
    void Start()
    {
        nextTime = getNextTime();
    }

    void Update()
    {
        if(Time.time > nextTime)
        {
            startingPosition.x = Random.Range(MIN_X, MAX_X);
            Instantiate(nextCube(), startingPosition, Quaternion.identity);
            nextTime = getNextTime();
        }
    }

    float getNextTime()
    {
        return Time.time + (Random.Range(MIN_TIME, MAX_TIME));
    }

    GameObject nextCube()
    {
        switch(Random.Range(0, 4))
        {
            case 0:
                return redCube;
            case 1:
                return yellowCube;
            case 2:
                return blueCube;
            default:
                return greenCube;
        }
    }
}
