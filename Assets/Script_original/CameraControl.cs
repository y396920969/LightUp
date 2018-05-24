using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public Transform MainCamera;
    public float speed = 10f;
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey("d"))
        {
            MainCamera.position = new Vector3(MainCamera.position.x,
                                              MainCamera.position.y,
                                              MainCamera.position.z + speed);
        }

        if (Input.GetKey("a"))
        {
            MainCamera.position = new Vector3(MainCamera.position.x,
                                              MainCamera.position.y,
                                              MainCamera.position.z - speed);
        }

        if (Input.GetKey("w") &&  MainCamera.position.x > 2)
        {
            MainCamera.position = new Vector3(MainCamera.position.x - speed,
                                              MainCamera.position.y - speed,
                                              MainCamera.position.z);
        }

        if (Input.GetKey("s") && MainCamera.position.x < 20)
        {
            MainCamera.position = new Vector3(MainCamera.position.x + speed,
                                              MainCamera.position.y + speed,
                                              MainCamera.position.z);
        }
	}
}
