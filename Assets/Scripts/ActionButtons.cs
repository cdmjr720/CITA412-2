using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Beetle.Spawn;
using Beetle.SceneManagement;
using Beetle.Count;

namespace Beetle.Action
{
    public class ActionButtons : MonoBehaviour
    {
        private float timeSinceClicked = Mathf.Infinity;
        [SerializeField] GameObject button;

        public void Start()
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        }

        public void OnPressPest()
        {
            timeSinceClicked = 0f;
            button.SetActive(false);
        }

        public void OnPressSci()
        {
            timeSinceClicked = 0f;
            button.SetActive(false);
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

