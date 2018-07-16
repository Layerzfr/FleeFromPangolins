using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CinematicDeuxController : MonoBehaviour {

    public GameObject Player;
    public GameObject Camera;
    public GameObject NopeBulle;
    public GameObject Boss;

    private float time = 0;
    private float timeSpeak = 0;
    private float i = 13.27f;
    private float y = -2.5f;
    private float run = 11f;
    private float runBoss = 11f;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("FleeFromPangolins");
        }
        time += Time.deltaTime;
        Camera.GetComponent<Transform>().position = new Vector3(13.27f, 0f, -10f);
        if(time > 2)
        {
            Player.GetComponent<PlayerController>().moveSpeed--;
            if(Player.GetComponent<PlayerController>().moveSpeed <= 0)
            {
                Player.GetComponent<PlayerController>().moveSpeed = 0;
                MoveCamera();
            }
        }
	}

    void MoveCamera()
    {
        if(i < 20) {
            i += 0.1f;
        }else if ( i >= 20)
        {
            Personnage();
        }
        
        Camera.GetComponent<Transform>().position = new Vector3(i, Camera.transform.position.y,Camera.transform.position.z);
    }

    void Personnage()
    {
        if(y <= 2.5f)
        {
            y += 0.5f;   

        }else if ( y >= 2.5f)
        {
            //StartCoroutine("Wait");
            Speak();
            /*NopeBulle.SetActive(false);
            run -= 0.1f;
            Player.GetComponent<PlayerController>().moveSpeed = 0.4f;
            Player.GetComponent<Transform>().position = new Vector3(run, Player.transform.position.y, Player.transform.position.z);*/
        }
        
    }

    void Speak()
    {
        NopeBulle.SetActive(true);
        timeSpeak += Time.deltaTime;
        if (timeSpeak > 2f)
        {
            Player.transform.localScale = new Vector3(y, Player.transform.localScale.y, Player.transform.localScale.z);
            Rotate();
        }
        
        
    }

    void Rotate()
    {
        NopeBulle.SetActive(false);
        run -= 0.3f;
        runBoss -= 0.3f;
        Player.GetComponent<PlayerController>().moveSpeed = 0.4f;
        Player.GetComponent<Transform>().position = new Vector3(run, Player.transform.position.y, Player.transform.position.z);
        Boss.GetComponent<Transform>().position = new Vector3(runBoss + 14f, Boss.transform.position.y, Boss.transform.position.z);
        if (time > 7)
        {
            SceneManager.LoadScene("FleeFromPangolins");
        }
    }

}
