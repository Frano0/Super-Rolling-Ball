using UnityEngine;
using Unity.VisualScripting;
using JetBrains.Annotations;

public class PlayerSphere : MonoBehaviour
{
    public Rigidbody rigid;
    public float power = 2f;
    public int score;
    public System.Boolean gameOver;
    public System.Boolean isWin;
    public int jumpForce = 1;
    private float cooldown = 0.2f;
    private float timer = 0f;
    private System.Boolean keyPressed = false;

    public float orientation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        score = 0;
        gameOver = false;
        isWin = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y < -60)
        {
            gameOver = true;
        }
        if (keyPressed) {
            timer += Time.deltaTime;
            if (timer > cooldown)
            {
                timer = 0;
                keyPressed = false;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && keyPressed == false)
        {
            keyPressed = true;
            rigid.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
