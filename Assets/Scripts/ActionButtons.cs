using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Beetle.Spawn;
using Beetle.SceneManagement;

namespace Beetle.Action
{
    public class ActionButtons : MonoBehaviour
    {

        public bool pressed = false;
        private float timeSinceClicked = Mathf.Infinity;
        [SerializeField] GameObject button;
        public int press;

        public void PressPress()
        {
            press = Random.Range(-50, 500);
            pressed = true;
        }

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
            PressPress();

            if (timeSinceClicked > 4.0f)
            {

                if (press > 0)
                {
                    Debug.Log(press);
                    //pressed = true;
                                
    }
}
            else
            {
                Debug.Log("cannot click");
            }

        }

        //public int beetleCount = FindObjectOfType<BeetleSpawner>().beetleCount;


        public void PestPress()
        {
            //            int press = Random.Range(-50, 500);
            PressPress();


            if (timeSinceClicked > 4.0f)
            {
                if (press > 0)
                {
                    Debug.Log(press);
                    pressed = true;

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
            if (timeSinceClicked > 4f && !button.active)
            {
                button.SetActive(true);
            }
        }


    }

}

