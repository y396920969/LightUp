using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    public float Yvelocity;
	private int status = 1;
	public KeyCode key = KeyCode.J;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(key)) {
			transform.Rotate(0, 0, 180, Space.Self);
			if (status == 0) {
				status = 1;
			} else {
				status = 0;
			}
		}
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something hit the boost");
		if (other.tag == "Player" && status == 0)
        {
            other.GetComponent<Rigidbody>().velocity = new Vector3(other.GetComponent<Rigidbody>().velocity.x, Yvelocity, other.GetComponent<Rigidbody>().velocity.z);
        }
    }
}
