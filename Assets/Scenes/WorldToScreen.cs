using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldToScreen : MonoBehaviour
{
    private float logDelay = 0.5f;
    private float lastLogTime = 0f;

    void Update()
    {
        if (Time.time - lastLogTime >= logDelay)
        {
            Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
            Debug.Log($"Screen Position: {screenPos}");
            lastLogTime = Time.time;
        }
    }
}
