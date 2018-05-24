using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring3 : MonoBehaviour {
	public float Yvelocity;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("Something hit the boost");
		if (other.tag == "Player")
		{
			other.GetComponent<Rigidbody>().velocity = new Vector3(other.GetComponent<Rigidbody>().velocity.x, Yvelocity, other.GetComponent<Rigidbody>().velocity.z);
		}
	}
}
