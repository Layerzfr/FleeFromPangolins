using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyController : MonoBehaviour {

    public GameObject PauseMenu;
    public GameObject DifficultyMenu;

    public void Easy()
    {
        SceneManager.LoadScene("Easy");
        Time.timeScale = 1f;
    }

    public void Normal()
    {
        SceneManager.LoadScene("FleeFromPangolins");
        Time.timeScale = 1f;
    }

    public void Hard()
    {
        SceneManager.LoadScene("Hard");
        Time.timeScale = 1f;
    }

    public void Back()
    {
        PauseMenu.SetActive(true);
        DifficultyMenu.SetActive(false);
    }

	
}
