using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeetleSpawner : MonoBehaviour
{
    private float waitTime = 4.0f;
    private float timer = 0.0f;

    public void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            // Remove the recorded 2 seconds.
            timer = timer - waitTime;
            Debug.Log("time up");
        }
    }
}