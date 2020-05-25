using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Quit the game
    public void QuitGame()
    {
        Application.Quit();
    }
    // Get the current scene from the index
    // Load the next scene
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);

    }
    // At the beginning of the game, load the initial scene
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);

    }

}
