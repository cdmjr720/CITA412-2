using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Beetle.Action;
using Beetle.Spawn;
using Beetle.SceneManagement;

namespace Beetle.Count
{
    public class Score : MonoBehaviour
    {
        public int beetleCount;
        int press;
        [SerializeField] GameObject button;


        void Start()
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            //beetleCount = 
        }

        void BeetleCounter()
        {
            if (beetleCount >= 0)
            {
                beetleCount = FindObjectOfType<BeetleSpawner>().beetleCount;
            }
            else
            {
                beetleCount = FindObjectOfType<BeetleSpawner>().beetleCount;
            }
        }

        void Update()
        {
            BeetleCounter();
        }

        public void PressPress()
        {
            press = Random.Range(-50, 500);
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

            if (beetleCount >= 2000)
            {
                if (beetleCount >= 2000)
                {
                    LoadLoseScene();
                }
            }
        }

        public void OnPressPest()
        {

            PressPress();
            BeetleCounter();
            if (press > 0)
            {
                Debug.Log(press);
                beetleCount = beetleCount - press;
                Debug.Log(beetleCount);
            }
            WinOrLose();

        }

        public void OnPressSci()
        {
            PressPress();
            BeetleCounter();
            if (press > 0)
            {
                Debug.Log(press);
                beetleCount = beetleCount - press;
                Debug.Log(beetleCount);
            }
            WinOrLose();

        }
    }
}
