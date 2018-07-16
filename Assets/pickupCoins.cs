using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupCoins : MonoBehaviour {

    public int scoreToGive;

    private ScoreManager theScoreManager;

    private AudioSource coinSound;


	// Use this for initialization
	void Start () {
        theScoreManager = FindObjectOfType<ScoreManager>();
        coinSound = GameObject.Find("coinSound").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            
            theScoreManager.AddScore(scoreToGive);
            gameObject.SetActive(false);
            if (coinSound.isPlaying)
            {
                coinSound.Stop();
                coinSound.Play();
            }
            else
            {
                coinSound.Play();
            }
            
        }
    }
}
