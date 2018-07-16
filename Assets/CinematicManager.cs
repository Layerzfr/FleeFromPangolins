using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CinematicManager : MonoBehaviour {

	public void Skip()
    {

        //Application.LoadLevel("FleeFromPangolins");
        SceneManager.LoadScene("FleeFromPangolins");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("FleeFromPangolins");
        }
    }
}
