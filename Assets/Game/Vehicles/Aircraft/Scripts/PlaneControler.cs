using UnityEngine;
using System.Collections;

public class PlaneControler : MonoBehaviour
{

    public float speedZ = 50.0f;
    public float speedX = 5.0f;

    private float rollEffect = 1f;                     // The strength of effect for roll input.

    private float minSpeedZ = 10.0f;
    private float curSpeedZ;

    void Start()
    {
        curSpeedZ = 15.0f;
    }

    void Update()
    {
        // move forward with our speed
        float step = curSpeedZ * Time.deltaTime;
        Vector3 temp = transform.position;
        temp.z += step;
        transform.position = temp;

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

        if (left)
        {
            this.rigidbody.AddForce(new Vector3(-5.0f, 0, 0));
            //temp.x -= step;
        }

        if (right)
        {
            //temp.x += step;
            this.rigidbody.AddForce(new Vector3(5.0f, 0, 0));
        }

        transform.position = temp;

        if (up)
        {
            curSpeedZ += 0.4f;
        }


        if (down)
        {
            curSpeedZ -= 0.2f;
        }

        curSpeedZ = Mathf.Clamp(curSpeedZ, minSpeedZ, speedZ);

    }

}
