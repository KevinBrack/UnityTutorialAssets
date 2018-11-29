using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // Whenever we use lowercase t it
        // is refers to the game object the script is 
        // a component on
        transform.position = player.position + offset;
    }
}
