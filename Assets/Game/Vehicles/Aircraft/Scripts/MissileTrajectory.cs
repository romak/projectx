using UnityEngine;
using System.Collections;

public class MissileTrajectory : MonoBehaviour
{

    public GameObject explosion;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.AddForce(transform.TransformDirection(Vector3.forward) * 60.0f);
    }

    void OnCollisionEnter(Collision collision)
    {
	    ContactPoint contact  = collision.contacts[0];

        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
        //Destroy(this);


    }

}
