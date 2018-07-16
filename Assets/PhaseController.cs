using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseController : MonoBehaviour {

    public GameObject previousPhase;
    public GameObject thisPhase;
    public GameObject nextPhase;

    
    public GameObject pauseMenu;
    public GameObject tutorialMenu;

	public void Previous()
    {
        previousPhase.SetActive(true);
        thisPhase.SetActive(false);
    }

    public void Next()
    {
        nextPhase.SetActive(true);
        thisPhase.SetActive(false);
    }

    public void GitGud()
    {
        nextPhase.SetActive(true);
        thisPhase.SetActive(false);
        pauseMenu.SetActive(true);
        tutorialMenu.SetActive(false);
    }
}
