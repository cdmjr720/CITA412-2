using UnityEngine;
using UnityEngine.SceneManagement;

//script for action button functions - primarily to make them disappear at beginning of the game and after clicking
//Was helped by Will getting the timer functions correct

namespace Beetle.Action
{
    public class ActionButtons : MonoBehaviour
    {
        public GameObject[] destroyClone;

        //variables for timeSinceClicked and button for functions
        private float timeSinceClicked = Mathf.Infinity;
        [SerializeField] GameObject button = null;

        public void Start()
        {
            //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            
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
        }
    }
}

