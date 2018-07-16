using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulleController : MonoBehaviour {

    public GameObject[] theObjectPools;
    private float timePassed = 0;
    private float rndTime = 5;
    private float rnd = 0;
    private int rndBulle = 0;
    private float newTime = 0;
    private bool check = false;

    // Use this for initialization
    void Start () {
        rndTime = Random.Range(4, 8);
    }

    void RandomBulle()
    {
        rnd = Random.Range(0, 4);
        rndBulle = Mathf.RoundToInt(rnd);
        check = true;
    }
	
	// Update is called once per frame
	void Update () {
        
        //System.Random rndTime = new System.Random();
        if (timePassed > rndTime)
        {
            if(check == false)
            {
                RandomBulle();
            }
            
            newTime += Time.deltaTime;

            
            GameObject bulle = theObjectPools[rndBulle];

            bulle.SetActive(true);
            
            if(newTime > 5)
            {
                timePassed = 0;
                newTime = 0;
                bulle.SetActive(false);
                rndTime = Random.Range(4, 8);
                check = false;
            }
        }
        else
        {
            timePassed += Time.deltaTime;
        }
        
	}
}
