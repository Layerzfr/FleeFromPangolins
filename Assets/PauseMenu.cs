using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public string mainMenuLevel;

    public GameObject pauseMenu;
    public GameObject tutorialMenu;
    public GameObject difficultyMenu;
    public bool pause = false;
    public bool tuto = false;
    public bool diff = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(pause == false)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }

    }

    public void PauseGame()
    {
        
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        pause = true;
    }

    public void ResumeGame()
    {
       /* if (tuto == true)
        {

            tutorialMenu.SetActive(false);
            tuto = false;

        } else if (diff == true)
        {

            diff = false;
            difficultyMenu.SetActive(false);
            
        }*/
        
            pause = false;
            Time.timeScale = 1f;
            if (difficultyMenu)
            {
                difficultyMenu.SetActive(false);
            }
            if (tutorialMenu)
            {
                tutorialMenu.SetActive(false);
            }
            pauseMenu.SetActive(false);
        
        
    }

    public void Tutorial()
    {
        tuto = true;
        tutorialMenu.SetActive(true);
        
    }

    public void Difficulty()
    {
        difficultyMenu.SetActive(true);
        diff = true;
    }

    public void RestartGame()
    {
        pause = false;
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        FindObjectOfType<GameManager>().Reset();
    }

    public void QuitToMain()
    {
        Time.timeScale = 1f;
        //Application.LoadLevel(mainMenuLevel);
        SceneManager.LoadScene(mainMenuLevel);
    }


}
