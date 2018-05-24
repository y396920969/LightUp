using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost2 : MonoBehaviour
{
    public float multiply;
    private int status = 1;
    public KeyCode key = KeyCode.J;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            if (status == 0)
            {
                status = 1;
                transform.position = new Vector3(transform.position.x, transform.position.y - 1000f, transform.position.z);
            }
            else
            {
                status = 0;
                transform.position = new Vector3(transform.position.x, transform.position.y + 1000f, transform.position.z);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something hit the boost");
        if (other.tag == "Player" & status == 0)
        {
            other.GetComponent<Rigidbody>().velocity = other.GetComponent<Rigidbody>().velocity * multiply;
        }
    }
}
