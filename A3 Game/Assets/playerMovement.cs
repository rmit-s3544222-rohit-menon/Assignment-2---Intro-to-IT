using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    public bool Ground = false;
    public Rigidbody rb;
    // Use this for initialization
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Ground = true;

        }

    }
    // Update is called once per frame
    void Update () {

        rb.AddForce(180 * Time.deltaTime, 0, 0);

        if(Input.GetKey("space"))
        {
            if (Ground)
            {

                rb.AddForce(000 * Time.deltaTime, 7000 * Time.deltaTime, 0 * Time.deltaTime);
                Ground = false;

            }
        }
	}
}
