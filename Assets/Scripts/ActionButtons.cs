using UnityEngine;
using UnityEngine.SceneManagement;
using Beetle.Count;

//script for action button functions - primarily to make them disappear at beginning of the game and after clicking
//Was helped by Will getting the timer functions correct

namespace Beetle.Action
{
    public class ActionButtons : MonoBehaviour
    {

        //attempt to destroy GameOjects
        public GameObject[] destroyClone;


        //creates bool isPressed to be called in other scripts
        public bool isPressed;

        //variables for timeSinceClicked and button for functions
        private float timeSinceClicked = Mathf.Infinity;
        [SerializeField] GameObject button = null;

        //beetleCount2 variable
        public int beetleCount2;
        
        public void Start()
        {
            //calls "Faster" method
            InvokeRepeating("Faster", 0f, 0.25f);
            //sets isPressed bool at false
            isPressed = false;

            //Sets the buttons to be inactive until timeSinceClicked is 0 to start the game
            timeSinceClicked = 0f;
            button.SetActive(false);
            //destroyClone = GameObject.FindGameObjectsWithTag("Beetle");
        }

        //function for Pesticide Button
        public void OnPressPest()
        {
            //Sets the button to be inactive until timeSinceclicked is 0 after clicking
            timeSinceClicked = 0f;
            button.SetActive(false);
            isPressed = true;

            //attempts at destroying game object
            //foreach (GameObject beetle in destroyClone)
            //{
            //    Destroy(beetle);
            //}
        }

        //function for Science Button
        public void OnPressSci()
        {
            //Sets the button to be inactive until timeSinceclicked is 0 after clicking
            timeSinceClicked = 0f;
            button.SetActive(false);
            isPressed = true;

            //attempts at destroying game object
            //foreach (GameObject beetle in destroyClone)
            //{
            //    Destroy(beetle);
            //}
        }

        public void Update()
        {
            //sets the timeSinceClicked at 3 frames (seconds)
            timeSinceClicked += Time.deltaTime;
            if (timeSinceClicked > 3f && !button.active)
            {
                button.SetActive(true);
            }
            if (!button.active)
            {
                //if button is not active, isPressed becomes False
                isPressed = false;
            }
        }

        //function Faster to be called faster than Update()
        public void Faster()
        {
            //inputs beetleCount into beetleCount2 variable
            beetleCount2 = FindObjectOfType<Score>().beetleCount;
        }
    }
}

