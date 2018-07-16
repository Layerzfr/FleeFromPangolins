using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public PlayerController thePlayer;
    public Camera CameraOrigine;

    private Vector3 lastPlayerPosition;
    private float distanceToMove;

    public bool cameraReverseCheck;

	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
        lastPlayerPosition = thePlayer.transform.position;
        if (cameraReverseCheck == true)
        {
            CameraMirror();
        }
    }
	
	// Update is called once per frame
	void Update () {
        

        distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x;

        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);

        lastPlayerPosition = thePlayer.transform.position;

	}

    void CameraMirror()
    {
        CameraOrigine.projectionMatrix = CameraOrigine.projectionMatrix * Matrix4x4.Scale(new Vector3(-1, 1, 1));
    }
}
