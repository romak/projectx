using UnityEngine;
using System.Collections;

public class PlaneControler : MonoBehaviour
{

    public float speedZ = 50.0f;
    public float speedX = 5.0f;
    public float forwardForce = 1.0f;

    public float turnSpeed = 10.0f;
    public float maxTurnLean = 50.0f;
    public float maxTilt = 50.0f;
    public float sensitivity = 10.0f;

    private float normalizedSpeed = 12.0f;
    private Vector3 euler = Vector3.zero;


    //private float rollEffect = 1f;                     // The strength of effect for roll input.
    private float minSpeedZ = 10.0f;
    private float curSpeedZ;

    private bool moveLeft = false;
    private bool moveRight = false;
    private bool moveUp = false;
    private bool moveDown = false;    

    private Vector3 accelerator = new Vector3(0, 0, 0);

    void Start()
    {
        curSpeedZ = 15.0f;
    }


    void FixedUpdate()
    {
        rigidbody.AddRelativeForce(0, 0, normalizedSpeed * forwardForce);

	    //Vector3 accelerator = new Vector3(0, 0, 0.5f);
        if (moveUp)
        {
            accelerator.y -= 0.01f;
        }

        if (moveDown)
        {
            accelerator.y += 0.01f;
        }

        if (moveLeft)
        {
            accelerator.x -= 0.003f;
            accelerator.z -= 0.06f;
        }

        if (moveRight)
        {
            accelerator.x += 0.003f;
            accelerator.z += 0.06f;
        }

        euler.z = Mathf.Lerp(euler.z, -accelerator.x * maxTurnLean, 0.2f);
        euler.y += accelerator.x * turnSpeed;
        euler.x = Mathf.Lerp(euler.x, accelerator.y * maxTilt, 0.2f);

	    Quaternion rot = Quaternion.Euler(euler);
        transform.rotation = Quaternion.Lerp(transform.rotation, rot, sensitivity);

        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.EulerRotation(0, 0, 1), Time.fixedDeltaTime * 1.5f);

//        Vector3 relativeSpeed = transform.InverseTransformDirection(rigidbody.velocity);
  //      rigidbody.AddRelativeForce(-relativeSpeed, ForceMode.VelocityChange);


    }

    void Update()
    {
        // move forward with our speed
        //float step = curSpeedZ * Time.deltaTime;
        //Vector3 temp = transform.position;
        //temp.z += step;
        //transform.position = temp;

        ProcessInput();

    }

    void ProcessInput()
    {
        float step = speedX * Time.deltaTime;
        bool left = Input.GetKey(KeyCode.LeftArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool up = Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.DownArrow);
        Vector3 temp = transform.position;

        moveLeft = false;
        moveRight = false;
        moveDown = false;
        moveUp = false;

        if (left)
        {
            moveLeft = true;
        }


        if (right)
        {
            moveRight = true;
        }


        if (down)
        {
            moveDown = true;
        }


        if (up)
        {
            moveUp = true;
        }

/*
        if (left)
        {
            this.rigidbody.AddForce(new Vector3(-2, 0, 0));
            //temp.x -= step;
        }

        if (right)
        {
            //temp.x += step;
            this.rigidbody.AddForce(new Vector3(2, 0, 0));
        }

        transform.position = temp;

        if (up)
        {
            curSpeedZ += (20.4f * Time.deltaTime);
        }


        if (down)
        {
            curSpeedZ -= (20.2f * Time.deltaTime);
        }

        curSpeedZ = Mathf.Clamp(curSpeedZ, minSpeedZ, speedZ);
*/

    }

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
    }

}
