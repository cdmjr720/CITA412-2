using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Beetle.Action;
using Beetle.Spawn;
using Beetle.Count;

namespace Beetle.SceneManagement
{
    public class SceneLoader : MonoBehaviour
    {
        
    public void LoadNextScene()
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1);
        }


        public void quitGame()
        {
            Application.Quit();
        }
    }

}
