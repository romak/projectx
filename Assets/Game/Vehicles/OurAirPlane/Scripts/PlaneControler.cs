using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlaneControler : MonoBehaviour
{
    public float speed      = 30.0f;
    public float speedX     = 0.05f;
    public float tilt       = 25.0f;
    public Text  label;

    float moveHorizontal = 0.0f;
    float moveVertical = 0.0f;

    void Start()
    {
    }

    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        Debug.Log(moveHorizontal);
        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        if (Input.touchCount == 1)
        {
            //float x = Input.touches[0].deltaPosition.normalized.x;
            //float y = Input.touches[0].deltaPosition.normalized.y;
            float x = Input.touches[0].deltaPosition.x * speed * Time.deltaTime;
            float y = Input.touches[0].deltaPosition.y * speed * Time.deltaTime;
            Vector3 v = new Vector3(x, 0.0f, y);
            //v = Vector3.ClampMagnitude(v, 1.0f);
            //moveHorizontal = v.x;
            //moveVertical = v.y;

            moveHorizontal = v.x;
            //moveVertical = v.y;
            moveVertical += 0.1f;
        }

        string str = moveHorizontal.ToString() + " tap " + Input.touchCount.ToString();
        label.text = str;
    }

    void FixedUpdate()
    {

        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        //float moveHorizontal = CrossPlatformInput.GetAxis("Horizontal");
        //float moveVertical = CrossPlatformInput.GetAxis("Vertical");

//        Debug.Log(moveHorizontal);
////        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
//        if (Input.touchCount > 0 )
//        {
//            float x = Input.touches[0].deltaPosition.x;
//            float y = Input.touches[0].deltaPosition.y;
//            Vector3 v = new Vector3(x, 0.0f, y);

//            v = Vector3.ClampMagnitude(v, 1.0f);
//            moveHorizontal = v.x;
//            moveVertical = v.y;

//            //v.Normalize();
//            //moveHorizontal = v.normalized.x;
//            //moveVertical = v.normalized.y;



//        }

//        moveVertical = Mathf.Clamp(moveVertical, 0.3f, 1.0f);

        moveVertical = Mathf.Clamp(moveVertical, 0.3f, 1.0f);
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, speed * moveVertical);
        rigidbody.velocity = movement * speedX;
        rigidbody.rotation = Quaternion.Euler(0.0f, 0.0f, rigidbody.velocity.x * -tilt);

    }

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
    }

}
