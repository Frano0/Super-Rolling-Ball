using UnityEngine;

public class BouncingCylinderScript : MonoBehaviour
{

    public float bouncingForce = 20.0f;

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<Rigidbody>() != null)
        {

            Vector3 contactNormal = collision.GetContact(0).normal;

            collision.gameObject.GetComponent<Rigidbody>().AddForce(-contactNormal * bouncingForce, ForceMode.Impulse);
        }

    }
}
