using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
	
	// We marked this as "Fixed"Update because we
    // are updating the physics engine
	void FixedUpdate () {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
	}
}
