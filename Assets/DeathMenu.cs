using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour {


    public string mainMenuLevel;

    public PlayerController thePlayer;

    public BackgroundController theBackground;

    public void RestartGame()
    {
        
        FindObjectOfType<GameManager>().Reset();
        
        thePlayer.buttonPause.SetActive(true);
    }

    public void QuitToMain()
    {
       // Application.LoadLevel(mainMenuLevel);
        SceneManager.LoadScene(mainMenuLevel);
    }

}
