using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Beetle.Action;
using Beetle.Spawn;
using Beetle.SceneManagement;
using TMPro;


namespace Beetle.Count
{
    public class Score : MonoBehaviour
    {

        public int beetleCount = 0;
        int press;
        [SerializeField] GameObject button;


        [SerializeField] float waitTime = 0;
        public GameObject beetle;
        public float spawnTimer;
        public float beetlesToclone;
        public GameObject spawnPoint;
        [SerializeField] TextMeshProUGUI beetleText;


        void Start()
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        }


        void Update()
        {
            beetlesToclone = 1;
            WinOrLose();
            beetleText.text = beetleCount.ToString();

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

        public void SpawnBeetle()
        {

            if (beetleCount >= 0)
            {
                GameObject clone;

                spawnPoint = beetle;
                clone = Instantiate(spawnPoint, transform.position, transform.rotation); //added spawnPoint to code
                clone.SetActive(true);
                beetleCount++;
                Debug.Log(beetleCount);
                transform.position = new Vector3(Random.Range(0.1f, 20f), Random.Range(0.1f, 10f), -7);
            }
        }

        public void PressPress()
        {
            //if (beetleCount > 250)
            //{
                press = 125;
            Debug.Log(press);
            Debug.Log(beetleCount);

            //}
        }

        public void LoadLoseScene()
        {
            SceneManager.LoadScene(3);
        }

        public void LoadWinScene()
        {
            SceneManager.LoadScene(2);
        }

        public void WinOrLose()
        {
            if (beetleCount < 0)
            {
                LoadWinScene();
            }

            if (beetleCount >= 500)
            {
                LoadLoseScene();
            }
        }

        public void OnPressPest()
        {

            PressPress();
            //BeetleCounter();
            if (press > 0)
            {
                Debug.Log(press);
                beetleCount = beetleCount - press;
                Debug.Log(beetleCount);
            }

        }

        public void OnPressSci()
        {
            PressPress();
            //BeetleCounter();
            if (press > 0)
            {
                Debug.Log(press);
                beetleCount = beetleCount - press;
                Debug.Log(beetleCount);
            }

        }
    }
}
