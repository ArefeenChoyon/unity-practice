using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    // Update is called once per frame
    // We Used "Fixed"Update method, because we are messing with physics stuffs, Unity likes it a lot
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);   //Add a force of 2000 to z-axix, "Delta" To fix the frame rate issue between computers, higher the frame rate lower the value
    }
}
