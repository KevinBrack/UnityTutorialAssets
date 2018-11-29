using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
	
	// We marked this as "Fixed"Update because we
    // are updating the physics engine
	void FixedUpdate () {
        // add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) {
            // Only executed if contition is met
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
