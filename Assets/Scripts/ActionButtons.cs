using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ActionButtons : MonoBehaviour
{ 
    private float timeSinceClicked = Mathf.Infinity;

    [SerializeField] GameObject button;
    
    public void OnPressPest()
    {
        PestPress();
        timeSinceClicked = 0f;
        button.SetActive(false);

    }

    public void OnPressSci()
    {
        SciPress();
        timeSinceClicked = 0f;
        button.SetActive(false);

    }

    public void SciPress()
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

        public void PestPress()
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
