using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_Start : MonoBehaviour {

    public Rigidbody rb;
    public Rigidbody dest;
    public int clickForce = 500;
    private Plane plane = new Plane(Vector3.up, Vector3.zero);
    public int forceDegree = 3;

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            float enter;
            if (plane.Raycast(ray, out enter))
            {
                var hitPoint = ray.GetPoint(enter);
                var mouseDir = hitPoint - gameObject.transform.position;
                mouseDir = mouseDir.normalized;
                rb.AddForce(mouseDir * clickForce * forceDegree);
            }
        }


        //if (rb.position.y < -1f)
        //{
        //    FindObjectOfType<GameManager>().EndGane();
        //}

        //if (rb.position.Equals(dest.position)){
            
        //}
    }


}
