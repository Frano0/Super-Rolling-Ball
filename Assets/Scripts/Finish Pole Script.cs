using System;
using UnityEngine;

public class FinishPoleScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        PlayerSphere sphere = collision.collider.GetComponent<PlayerSphere>();
        if (sphere != null)
        {
            sphere.isWin = true;
        }
        
    }
}
