
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        // At first we checked for a name match of
        // the object that the player collided with.
        // This works but is taxing on the system.

        // if (collisionInfo.collider.name == "Obstacle")
        // {
        //     Debug.Log("We hit an Obstacle");

        // }

        // A better way to do this is to create a
        // tag and add it to the Obstacle object in unity
        // This way any object we want can become an 
        // obstacle and inherit this functionality
        // simply by adding the object tag

        if (collisionInfo.collider.tag == "Obstacle")
        {
            // Disables movement upon collision with
            // obstacle
            movement.enabled = false;
        }
    }

}
