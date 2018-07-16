using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallController : MonoBehaviour {

    public GameObject Boss;
    public GameObject FallPoint;
    public GameObject Camera;
    public GameObject Player;
    public GameObject Exclamation;
    public GameObject Audio;

    //public AudioSource fallSound;
    public AudioSource backgroundSound;

    private float test;
    private float test2;

    private bool playerStop;

    private float time = 0;


	// Use this for initialization
	void Start () {
        backgroundSound.Play();
        Audio.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        test = Camera.transform.position.x;
        test2 = FallPoint.transform.position.x;

        if (test > test2)
        {
            Boss.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        if(Boss.transform.position.y < 0.5)
        {
            playerStop = true;
            //fallSound.Play();
            Audio.SetActive(true);
            backgroundSound.Stop();
            
            Exclamation.SetActive(true);
            Wait();

        }
        if(time > 5)
        {
            SceneManager.LoadScene("Cinematic 1");
        }
        
	}

    void Wait()
    {
        time += Time.deltaTime;
        if(time > 2)
        {
            Player.GetComponent<PlayerController>().moveSpeed = 10;
            Exclamation.SetActive(false);
        }
        else if(time > 1)
        {
            Camera.GetComponent<Animator>().enabled = false;
        }
        else
        {
            Camera.GetComponent<Animator>().enabled = true;
            Player.GetComponent<PlayerController>().moveSpeed = 0;
            Camera.GetComponent<CameraController>().enabled = false;
            
        }
    }
}
