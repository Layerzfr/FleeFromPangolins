using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string playGameLevel;
    private bool Skip = true;

	public void PlayGame()
    {
        //Application.LoadLevel(playGameLevel);
        if(Skip == true)
        {
            SceneManager.LoadScene("FleeFromPangolins");
        }
        else
        {
            SceneManager.LoadScene(playGameLevel);
        }
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SkipEvent()
    {
        Skip = !Skip;
    }
}
