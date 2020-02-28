using UnityEngine;
using UnityEngine.SceneManagement;
using Beetle.Action;

//all beetle spawning and removal is placed inside of this script
//Credit to Will for helping figure out how to remove beetle gameObjects from screen

namespace Beetle.Count
{
    public class Score : MonoBehaviour
    {
        //creates beetleCount variable, the most important variable in the game, and sets it at 0
        public int beetleCount = 0;
        //creates press variable to count how many beetles are removed
        [SerializeField] int press;

        //variables for spawnTimer and waitTime for beetle spawning timer
        public float spawnTimer;
        [SerializeField] float waitTime = 0;

        //creates beetle GameObject
        public beetleScript beetle;

        //creates float for the amount of beetles to clone
        public float beetlesToclone;

        //sets a spawnpoint and creates a GameObject for the cloned beetle
        public GameObject spawnPoint;
        public beetleScript clone;

        //creates isPressed variables from ActionButtons script
        public ActionButtons sciIsPressed;
        public ActionButtons pestIsPressed;

        void Start()
        {
            //calls the SceneManager script in order to move to Win or Loss screens
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
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
                //spawnPoint = beetle;
                //clones a new beetle or beetles based on the spawnpoint
                clone = Instantiate(beetle, transform.position, transform.rotation);
                //creates the ID on beetles cloned
                clone.CreateID(beetleCount);
                clone.gameObject.SetActive(true);
                //increases the beetleCount by number spawned
                beetleCount++;              
                //sets the position of the spawn a certain distance from previous beetle
                transform.position = new Vector3(Random.Range(0.1f, 20f), Random.Range(0.1f, 10f), -7);
            }
        }

        //creates an overall "Press" function to check buttons are pressed, lowers beetleCount by value of pressed and deletes
        public void PressPress()
        {
            if (sciIsPressed.isPressed)
            {
                //finds beetleScript with variable allBeetles
                beetleScript[] allBeetles = FindObjectsOfType<beetleScript>();
                //for each beetle in beetleScript, removes beetles with value of press
                foreach (beetleScript beetle  in allBeetles)
                {
                    if (beetle.GetBeetleID() > beetleCount -press && beetle.GetBeetleID() < beetleCount)
                    {
                        Destroy(beetle.gameObject);
                    }
                }
                //removes press value from beetleCount
                beetleCount = beetleCount - press;
                Debug.Log(beetleCount);
            }

            if (pestIsPressed.isPressed)
            {
                //finds beetleScript with variable allBeetles

                beetleScript[] allBeetles = FindObjectsOfType<beetleScript>();
                //for each beetle in beetleScript, removes beetles with value of press
                foreach (beetleScript beetle in allBeetles)
                {
                    if (beetle.GetBeetleID() > beetleCount - press && beetle.GetBeetleID() < beetleCount)
                    {
                        Destroy(beetle.gameObject);
                    }
                }

                beetleCount = beetleCount - press;
                //removes press value from beetleCount
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
