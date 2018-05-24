using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost3 : MonoBehaviour {
	public float multiply;
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
			other.GetComponent<Rigidbody>().velocity = other.GetComponent<Rigidbody>().velocity * multiply;
		}
	}
}
