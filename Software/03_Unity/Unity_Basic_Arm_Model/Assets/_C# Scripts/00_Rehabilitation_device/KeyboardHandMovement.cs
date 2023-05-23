using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardHandMovement : MonoBehaviour {
    
    public float moveSpeed = 30.0f;

    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        //transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

        int rotation = 0;
        if (Input.GetKey(KeyCode.E))
            rotation = -1;
        else if (Input.GetKey(KeyCode.Q))
            rotation = 1;

       transform.Rotate(Vector3.forward * rotation * moveSpeed * Time.deltaTime);

        //int up_down = 0;
        //if (Input.GetKey(KeyCode.R))
        //    up_down = 1;
        //else if (Input.GetKey(KeyCode.F))
        //    up_down = -1;

        //transform.Translate(0, up_down * moveSpeed * Time.deltaTime, 0);

        //transform.Rotate(new Vector3(0, 0, 1), rotation * moveSpeed * Time.deltaTime);
        //doorHandle.Rotate(new Vector3(0, 0, 1), -rotation * moveSpeed * Time.deltaTime);
    }

}
