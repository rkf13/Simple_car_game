using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerLeft : MonoBehaviour
{
    public GameObject player;
    private Vector3 mainOffset = new Vector3(0, 10, -10);
    private Vector3 fpOffset = new Vector3(0, 2, 2);
    private Vector3 backOffset = new Vector3(0, 2, -2);
    private Vector3 sideOffset = new Vector3(20, 10, 0);
    private Vector3 topOffset = new Vector3(0, 30, 0);
    public int camIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // changes camera using spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            camIndex = (camIndex + 1) % 5;
        }

        // sets camera using 1-5 buttons
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            camIndex = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            camIndex = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            camIndex = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            camIndex = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            camIndex = 4;
        }

        // sets camera based off camera index 
        if (camIndex == 0)
        {
            // offset the camera behind the player
            transform.position = player.transform.position + mainOffset;
            // transform.Rotate(0, 0, 0);
            transform.eulerAngles = new Vector3(23, 0, 0);
        }

        else if (camIndex == 1)
        {
            // first person camera
            transform.position = player.transform.position + fpOffset;
            // transform.Rotate(0, 0, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        else if (camIndex == 2)
        {
            // side view
            transform.position = player.transform.position + sideOffset;
            // transform.Rotate(0, -90, 0);
            transform.eulerAngles = new Vector3(0, -90, 0);
        }

        else if (camIndex == 3)
        {
            // top view
            transform.position = player.transform.position + topOffset;
            // transform.Rotate(90, 0, 0);
            transform.eulerAngles = new Vector3(90, 0, 0);
        }

        else if (camIndex == 4)
        {
            // look behind
            transform.position = player.transform.position + backOffset;
            // transform.Rotate(0, 180, 0);
            transform.eulerAngles = new Vector3(0, 180, 0);

        }
    }
}
