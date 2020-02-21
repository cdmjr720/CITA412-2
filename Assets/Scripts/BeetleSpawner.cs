using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Beetle.Action;
using Beetle.SceneManagement;
using UnityEngine.SceneManagement;



namespace Beetle.Spawn
{
    public class BeetleSpawner : MonoBehaviour
    {
        public int press;
        private bool pressed = false;
        [SerializeField] float waitTime;
        private float timer = 0.0f;
        public GameObject beetle;
        private Vector3 position;
        Quaternion rotation;
        public float spawnTimer;
        [SerializeField] Transform spawnPoint;
        [SerializeField] float distance;
        [SerializeField] float beetlesToclone = 0;
        public int beetleCount = 1;
        private GameObject winScenario;
        public GameObject spawnPoint2;
        public bool spawnBeetleBool;
        public GameObject target;
        public bool win = false;
        public bool lose = false;
        
        public void Start()
        {
            pressed = FindObjectOfType<ActionButtons>().pressed;
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        }

        public void Pressing()
        {
            FindObjectOfType<ActionButtons>().PressPress();
            press = FindObjectOfType<ActionButtons>().press;
            //pressed = false;
        }

        public void Pressed()
        {
            Pressing();

            if (pressed == true)
            {
                Debug.Log("Pressed is true");
                beetleCount = beetleCount - press;

            }
        }

      public void Update()
        {
            spawnTimer += Time.deltaTime;
            if (spawnTimer > waitTime)
            {
                // Remove the recorded 2 seconds.
                spawnTimer = spawnTimer - waitTime;
                Debug.Log("time up");

                for (int i = 0; i < beetlesToclone; i++)
                {
                    SpawnBeetle();

                }

            }
        }


        public void LoadWinScene()
        {
            //if (beetleCount <= 0)
            //{
                win = true;
                Debug.Log("Win!");
                SceneManager.LoadScene(2);

            //}
        }

        public void LoadLoseScene()
        {
                lose = true;
                Debug.Log("Lose!");
                SceneManager.LoadScene(3);


        }




        public void SpawnBeetle()
        {
            Pressed();

            if (beetleCount <= 0)
            {
                    LoadWinScene();
                //GameObject clone;
                //clone = Instantiate(beetle, spawnPoint.position, spawnPoint.rotation); //added spawnPoint to code
                //clone.SetActive(true);
                //beetleCount++;
                //transform.position = new Vector3(Random.Range(0.1f, 20f), Random.Range(0.1f, 10f), -7);

            }
            if (beetleCount >= 1)
            {

                GameObject clone;

                spawnPoint2 = beetle;
                clone = Instantiate(spawnPoint2, transform.position, transform.rotation); //added spawnPoint to code
                clone.SetActive(true);
                beetleCount++;
                transform.position = new Vector3(Random.Range(0.1f, 20f), Random.Range(0.1f, 10f), -7);
            }
            if (beetleCount >= 2000)
            {
                LoadLoseScene();
            }
        }
    }
}

