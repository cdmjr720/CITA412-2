using UnityEngine;
using UnityEngine.SceneManagement;

//Scene Loader for main screen to advance into game

namespace Beetle.SceneManagement
{
    public class SceneLoader : MonoBehaviour

    {
        //function to load the next scene
        public void LoadNextScene()
        {
            //creates the scene index as an int
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            //calls the next active scene
            SceneManager.LoadScene(currentSceneIndex + 1);
        }

        //function to main menu
        public void LoadMenu()
        {
            //creates the scene index as an int
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            //calls the next active scene
            SceneManager.LoadScene(0);
        }
    }
}
