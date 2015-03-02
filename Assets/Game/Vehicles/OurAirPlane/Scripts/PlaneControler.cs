using UnityEngine;
using System.Collections;

public class PlaneControler : MonoBehaviour
{
    public float speed      = 20.0f;
    public float speedX     = 5.0f;
    public float tilt       = 25.0f;

    void Start()
    {
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        moveVertical = Mathf.Clamp(moveVertical, 0.3f, 1.0f);

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, speed * moveVertical);
        rigidbody.velocity = movement * speedX;
/*
        rigidbody.position = new Vector3
        (
            rigidbody.position.x,
            0.0f,
            Mathf.Clamp(rigidbody.position.z, rigidbody.position.z, rigidbody.position.z+100)
        );
*/
        rigidbody.rotation = Quaternion.Euler(0.0f, 0.0f, rigidbody.velocity.x * -tilt);

    }

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
    }

}
