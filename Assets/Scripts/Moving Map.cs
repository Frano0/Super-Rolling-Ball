using UnityEngine;

public class MovingMap : MonoBehaviour
{

    public PlayerSphere player;
    public float rotationSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rotationSpeed = 35;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left") && player.isWin == false)
        {
            //transform.Rotate(0, 0, player.orientation * rotationSpeed * Time.deltaTime);
            // Using RotateAround ?
            transform.RotateAround(player.transform.position, Vector3.forward, player.orientation * rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey("down") && player.isWin == false)
        {
            //transform.Rotate(- player.orientation * rotationSpeed * Time.deltaTime, 0, 0);
            transform.RotateAround(player.transform.position, Vector3.left, player.orientation * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey("right") && player.isWin == false)
        {
            //transform.Rotate(0, 0, -player.orientation * rotationSpeed * Time.deltaTime);
            transform.RotateAround(player.transform.position, Vector3.back, player.orientation * rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey("up") && player.isWin == false)
        {
            //transform.Rotate(player.orientation * rotationSpeed * Time.deltaTime, 0, 0);
            transform.RotateAround(player.transform.position, Vector3.right, player.orientation * rotationSpeed * Time.deltaTime);
        }
    }
}
