using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {


    public float speed;
    public GameObject Background;
    public PlayerController thePlayer;
    public float moveSpeedIncrStock;
    public float stock;
    public bool stop;

    public float test = 1;
	// Use this for initialization
	void Start () {
        moveSpeedIncrStock = thePlayer.moveSpeed;
        stock = speed;
	}
	
	// Update is called once per frame
	void Update () {

        if (stop == false)
        {
            if (thePlayer.moveSpeed != moveSpeedIncrStock)
            {
                test = speed * ((Time.time * thePlayer.speedMultiplier) / 5);
                moveSpeedIncrStock = thePlayer.moveSpeed;
               
            }
            
            /*if (moveSpeedIncrStock != thePlayer.moveSpeed)
            {
                speed = speed * (thePlayer.moveSpeed / 10);
                moveSpeedIncrStock = thePlayer.moveSpeed;
            }*/



            Vector2 offset = new Vector2(speed * ((Time.time * thePlayer.speedMultiplier) / 5), 0);

            Background.GetComponent<Renderer>().material.mainTextureOffset = offset;
        }
        //speed = (Time.time * thePlayer.speedMultiplier) / 5;

    }
}
