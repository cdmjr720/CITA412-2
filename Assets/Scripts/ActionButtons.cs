using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ActionButtons : MonoBehaviour
{ 
    private float timeSinceClicked = Mathf.Infinity;

    [SerializeField] GameObject button;

    //[SerializeField] Button sciButton;
    //GameObject button;
    
    public void OnPressPest()
    {
        Press();
        timeSinceClicked = 0f;
        button.SetActive(false);

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
        if (timeSinceClicked >4f && !button.active)
        {
            button.SetActive(true);
        }
    }


}
