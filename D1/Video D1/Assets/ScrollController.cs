using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollController : MonoBehaviour
{
    MeshRenderer renderer;
    const float scrollingSpeedX = 0.3f;
    Vector2 currentPos = Vector2.zero;
    private void Awake()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        currentPos.x += scrollingSpeedX * Time.deltaTime;
        renderer.material.mainTextureOffset = currentPos;
    }
}
