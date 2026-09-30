using UnityEngine;

public class FollowingCamera : MonoBehaviour
{

    public PlayerSphere player;
    public System.Boolean orientationChange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        orientationChange = false;
        player.orientation = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (orientationChange)
        {
            transform.Rotate(0, 180f, 0, Space.World);
            player.orientation = -player.orientation;
            orientationChange = false;
        }
        transform.position = player.transform.position + new Vector3(0, 5, -8 * player.orientation);
        
    }
}
