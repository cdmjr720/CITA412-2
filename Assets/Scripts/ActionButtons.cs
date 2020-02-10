using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionButtons : MonoBehaviour
{
    int start = 1;

    public void OnPressPest()
    {
        Press();
    }

    public void OnPressSci()
    {
        Press();
    }

    void Press()
    {
        int press = Random.Range(-500, 500);
        if (press >= -500)
        {
            Debug.Log(press);
        }
    }
}
