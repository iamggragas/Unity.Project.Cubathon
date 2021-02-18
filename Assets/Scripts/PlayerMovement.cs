using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;                                                        //this is a reference to a rigidbody component
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    void FixedUpdate()                                                          // we marked this as "fixed update" because we are using it to mess with physics
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);                       // add force on z axis

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
		{
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
		{
            FindObjectOfType<GameManager>().EndGame();
		}
    }
}
