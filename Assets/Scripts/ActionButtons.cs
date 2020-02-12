using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActionButtons : MonoBehaviour
{ 
    private float timeSinceClicked = Mathf.Infinity;

    public void OnPressPest()
    {
        Press();
        timeSinceClicked = 0f;

    }

    public void OnPressSci()
    {
        Press();
        timeSinceClicked = 0f;

    }

    public void Press()
    { 
        int press = Random.Range(-50, 500);
        if (timeSinceClicked > 4.0f)
        {
            if (press >= -50)
            {
                Debug.Log(press);
            }
        }
        else
        {
            Debug.Log("cannot click");
        }

    }

   
    public void Update()
    {
        timeSinceClicked += Time.deltaTime;
    }


}
