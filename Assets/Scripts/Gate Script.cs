using UnityEngine;

public class GateScript : MonoBehaviour
{
    public FollowingCamera camera;
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Starts a rotating animation around the player to change the camera angle. Should be reversible in case the player enters the gate again from the other side.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerSphere>() != null)
        {
            camera.orientationChange = true;

        }
    }
}
