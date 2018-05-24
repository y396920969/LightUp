using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject otherPortal;

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
        Debug.Log("Something hit the portal");
        if (other.tag == "Player")     
        {
            other.transform.position = otherPortal.transform.position + otherPortal.transform.forward * 2;
     
            //other.transform.position = new Vector3(otherPortal.transform.position.x, otherPortal.transform.position.y, otherPortal.transform.position.z);   
        }
    }
}
