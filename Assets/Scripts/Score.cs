using UnityEngine;
using UnityEngine.SceneManagement;
using Beetle.Action;

//all beetle spawning and removal is placed inside of this script

namespace Beetle.Count
{
    public class Score : MonoBehaviour
    {
        //creates beetleCount variable, the most important variable in the game, and sets it at 0
        public int beetleCount = 0;
        //creates press variable to count how many beetles are removed
        public int press;

       // public int beetleCount2;

        //[SerializeField] GameObject button;

        //variables for spawnTimer and waitTime for beetle spawning timer
        public float spawnTimer;
        [SerializeField] float waitTime = 0;

        //creates beetle GameObject
        public GameObject beetle;

        //creates float for the amount of beetles to clone
        public float beetlesToclone;

        //sets a spawnpoint and creates a GameObject for the cloned beetle
        public GameObject spawnPoint;
        public GameObject clone;

        //creates isPressed variables from ActionButtons script
        public ActionButtons sciIsPressed;
        public ActionButtons pestIsPressed;

        void Start()
        {
            //calls the SceneManager script in order to move to Win or Loss screens
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            //calls "Faster" function to repeat
            InvokeRepeating("Faster", 0f, .001f);
        }

        void Update()
        {
            //sets beetlesToClone at 1 and calls the WinOrLose function once per frame to check for Win/Loss conditions
            beetlesToclone = 1;
            WinOrLose();
            
            //calls the spawnTimer in order to spawn a certain number of beetles per frame
            spawnTimer += Time.deltaTime;
            if (spawnTimer > waitTime)
            {
                spawnTimer = spawnTimer - waitTime;
                for (int i = 0; i < beetlesToclone; i++)
                {
                    SpawnBeetle();
                }
            }
        }

        //creates function for spawning beetles
        public void SpawnBeetle()
        {
            if (beetleCount >= 0)
            {
                //sets the spawnpoint as a previous beetle
                spawnPoint = beetle;
                //clones a new beetle or beetles based on the spawnpoint
                clone = Instantiate(spawnPoint, transform.position, transform.rotation);
                clone.SetActive(true);
                //increases the beetleCount by number spawned
                beetleCount++;
                
                //Debug.Log(beetleCount);
                //sets the position of the spawn a certain distance from previous beetle
                transform.position = new Vector3(Random.Range(0.1f, 20f), Random.Range(0.1f, 10f), -7);
            }
        }

        //attempt to create a void that will update faster than update
        public void Faster()
        {
            //beetleCount2 = beetleCount;

            //Debug.Log(beetleCount2);
        }

        //creates an overall "Press" function
        public void PressPress()
        {
            //if buttons are pressed, lowers beetleCount by 125
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

        //function to load the Lose Scene
        public void LoadLoseScene()
        {
            SceneManager.LoadScene(3);
        }

        //function to load the Win Scene
        public void LoadWinScene()
        {
            SceneManager.LoadScene(2);
        }

        //function for Win/Loss scenarios
        public void WinOrLose()
        {
            //if beetleCount reaches 0 or lower, the player wins
            if (beetleCount < 0)
            {
                LoadWinScene();
            }

            //if beetleCount reaches 500 or greater, the player loses
            if (beetleCount >= 500)
            {
                LoadLoseScene();
            }
        }
    }
}
