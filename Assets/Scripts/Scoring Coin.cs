using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringCoin : MonoBehaviour
{
    public PlayerSphere playerSphere;
    public Rigidbody rigid;
    public float torque = 0.001f;

    private void OnTriggerEnter(Collider other) {

        PlayerSphere controller = other.gameObject.GetComponent<PlayerSphere>();

        if (controller != null)
        {
            controller.score += 1;
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        
        rigid.AddTorque(Vector3.up * torque, ForceMode.Impulse);
 
    }
}