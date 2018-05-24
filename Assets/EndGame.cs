using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {
    public Rigidbody dest;

	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" || other.tag == "Revive") {
            Vector3 position = transform.position;
            transform.position = dest.position;
            dest.position = position;
        }
    }
}
