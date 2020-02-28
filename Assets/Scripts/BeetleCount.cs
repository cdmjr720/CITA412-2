using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Beetle.Action;
using TMPro;

namespace Beetle.Count
{
    public class BeetleCount : MonoBehaviour
    {
        //variable for beetleCount
        public int beetleCount;
        //bool to return pressTrue as false
        public bool pressTrue = false;
        //variable for press set at 125
        [SerializeField] int press;

        //creates isPressed variables from ActionButtons script
        public ActionButtons sciIsPressed;
        public ActionButtons pestIsPressed;

        //variables for TMP text and beetlecount
        [SerializeField] TextMeshProUGUI beetleText;

        void Start()
        {
            //calls the Faster method 1 frame after start repeating at 0.002 frames after
            InvokeRepeating("Faster", 1f, 0.002f);
        }

        //function Faster to run faster than Update()
        public void Faster()
        {
            //calls beetleCount from Score script
            beetleCount = FindObjectOfType<Score>().beetleCount;
        }

        void Update()
        {
            //calls Press function
            Press();
            //adds beetleCount to text on game screen
            beetleText.text = beetleCount.ToString();
        }

        //function to check for button press
        public void Press()
        {
            //if buttons are pressed, beetleCount lowers by value of press
            if (sciIsPressed.isPressed)
            {
                beetleCount = beetleCount - press;
                Debug.Log(beetleCount);
            }
            if (pestIsPressed.isPressed)
            {
                beetleCount = beetleCount - press;
                Debug.Log(beetleCount);
            }
        }
    }
}

