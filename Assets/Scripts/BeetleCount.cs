using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Beetle.Action;
using TMPro;

namespace Beetle.Count
{
    public class BeetleCount : MonoBehaviour
    {
        public int beetleCount;
        public bool pressTrue = false;
        public int press;

        //creates isPressed variables from ActionButtons script
        public ActionButtons sciIsPressed;
        public ActionButtons pestIsPressed;

        //variables for TMP text and beetlecount
        [SerializeField] TextMeshProUGUI beetleText;

        void Start()
        {
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
            //if buttons are pressed, beetleCount lowers by 125
            if (sciIsPressed.isPressed)
            {
                beetleCount = beetleCount - 125;
                Debug.Log(beetleCount);
            }
            if (pestIsPressed.isPressed)
            {
                beetleCount = beetleCount - 125;
                Debug.Log(beetleCount);
            }
        }
    }
}

