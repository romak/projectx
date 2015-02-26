using UnityEngine;
using System.Collections;

public class PlaneControler : MonoBehaviour
{

    public float speed     = 20.0f;
    public float speedX = 2.0f;
    public float rollSpeedZ = 20.0f;
    public float rollSpeedX = 10.0f;

    float rollRate = 20.0f;
    float maxRoll = 45.0f;
    float curRollAngle = 0.0f;
    float nextRollAngle = 0.0f;
    float rotateStep = 1.0f;

    bool animStarted = false;
    Quaternion startRotation;

    public Animator planeAnim;
    public AnimationClip rollLeft;
    public AnimationClip rollRight;

    void Start()
    {
        if (rollLeft)
        {
            planeAnim.animation.AddClip(rollLeft, "rollLeft");
        }

        if (rollRight)
        {
            planeAnim.animation.AddClip(rollRight, "rollRight");
        }

    }

    IEnumerator TweenRotation(Transform trans, Quaternion destRot, float speed, float threshold)
    {
        float angleDist = Quaternion.Angle(trans.rotation, destRot);

        while (angleDist > threshold)
        {
            trans.rotation = Quaternion.RotateTowards(trans.rotation, destRot, Time.deltaTime * speed);
            yield return null;

            angleDist = Quaternion.Angle(trans.rotation, destRot);
        }
    }

    void Update()
    {
        float transAmount = speed * Time.deltaTime;
        float rotateAmountZ = rollSpeedZ * Time.deltaTime;
        float rotateAmountX = rollSpeedX * Time.deltaTime;
        float _speedX = speedX *Time.deltaTime;

        transform.Translate(0, 0, (transAmount * 2));

        if (Input.GetKey("left"))
        {
            //transform.Rotate(0, -rotateAmountX, 0);
            transform.Rotate(0, 0, rotateAmountZ*5);
        }

        if (Input.GetKey("right"))
        {
//            transform.Rotate(0, rotateAmountX, 0);
            transform.Rotate(0, 0, -rotateAmountZ * 5);
        }

        return;
/*
        // pre-animation example
        startRotation = transform.rotation;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotateStep = 1.0f;
            animStarted = true;
            if (!planeAnim.animation.IsPlaying("rollLeft"))
                planeAnim.animation.CrossFade("rollLeft");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotateStep = -1.0f;
            animStarted = true;
            if (!planeAnim.animation.IsPlaying("rollRight"))
                planeAnim.animation.CrossFade("rollRight");
        }

        if (animStarted)
        {
            //Quaternion currentRotation = Quaternion.Euler(0, 0, curRollAngle);
            //transform.rotation = Quaternion.Slerp(startRotation, currentRotation, Time.time * 20.5f);
            //curRollAngle += rotateStep;
        }

        if (curRollAngle >= 45 || curRollAngle <= -45 || curRollAngle == 0)
        {
            animStarted = false;
        }
        */

    }

    void FixedUpdate()
    {
        startRotation = transform.rotation;

        //curRollAngle = transform.eulerAngles.z;
        //rigidbody.AddRelativeForce(Vector3.up * velocity * planeLift);
        //rigidbody.AddRelativeForce(0, 0, speed);

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    rotateStep = 1.0f;
        //    animStarted = true;
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    rotateStep = -1.0f;
        //    animStarted = true;
        //}

        //if (animStarted)
        //{
        //    Quaternion currentRotation = Quaternion.Euler(0, 0, curRollAngle);
        //    //Quaternion r = Quaternion.AngleAxis(curRollAngle, Vector3.forward);

        //    //transform.rotation = Quaternion.RotateTowards(transform.rotation, currentRotation, 45);
        //    //transform.rotation = Quaternion.Slerp(startRotation, currentRotation, Time.time * 0.5f);

        //    transform.transform.RotateAround(Vector3.forward, -0.005f);
        //    curRollAngle += rotateStep;
        //}

        //if (curRollAngle >= 45 || curRollAngle <= -45 || curRollAngle ==0)
        //{
        //    animStarted = false;
        //}








/*
        if (animatingRollLeft)
        {
            animatingRollLeftStarted = true;
        }

        if (animatingRollRight)
        {
            animatingRollRightStarted = true;
        }


        if (animatingRollLeftStarted) {
            curRollAngle += rotateStep;
        }


        if (curRollAngle >= 90)
        {
            animatingRollLeftStarted = false;
        }

        if (animatingRollLeftStarted )
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, curRollAngle), Time.time * 5);

            if (curRollAngle >= 90)
            {
                //animatingRollLeftStarted = false;
            }
        }
*/


        //if (animatingRollRightStarted )
        //{
        //    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, -curRollAngle), Time.time * 5);
        //    curRollAngle += 1;

        //    if (curRollAngle >= 90)
        //    {
        //        animatingRollRightStarted= false;
        //    }
        //}






        //rigidbody.AddRelativeTorque(0, 0, curRoll);


        if (Input.GetKey(KeyCode.LeftArrow))
        {


//            nextRollAngle += transform.eulerAngles.y + (rollSpeed );
//            curRollAngle = Mathf.LerpAngle(curRollAngle, nextRollAngle, 100 * Time.deltaTime);

//            Quaternion rot = Quaternion.Euler(0, 0, 40);
////            transform.rotation = Quaternion.Lerp(transform.rotation, rot, 100 * Time.deltaTime);
//  //          transform.Rotate(0, 0, Time.deltaTime * 100 * (1.0 - rightleftsoftabs ) * Input.GetAxis("Horizontal") * -1.0); 		

//            //TweenRotation(transform, rot, 100, 100);
//            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.EulerRotation(0, 0, 1), Time.fixedDeltaTime * 0.5f);


//            //print(nextRollAngle);
        }

        //euler.z =



        //print(curRoll);
//        curRoll = Mathf.Clamp(curRoll, 0.0f, maxRoll);



        // move airplane forward        
        //Vector3 forces = Vector3.zero;
        //forces += speedZ * transform.forward;
        //rigidbody.AddForce(forces);




        //rigidbody.AddRelativeForce(0, 0, speedZ);

	    //Vector3 accelerator = new Vector3(0, 0, 0.5f);
//        if (moveUp)
//        {
//            accelerator.y -= 0.01f;
//        }

//        if (moveDown)
//        {
//            accelerator.y += 0.01f;
//        }

//        if (moveLeft)
//        {
//            accelerator.x -= 0.003f;
//            accelerator.z -= 0.06f;
//        }

//        if (moveRight)
//        {
//            accelerator.x += 0.003f;
//            accelerator.z += 0.06f;
//        }

//        euler.z = Mathf.Lerp(euler.z, -accelerator.x * maxTurnLean, 0.2f);
//        euler.y += accelerator.x * turnSpeed;
//        euler.x = Mathf.Lerp(euler.x, accelerator.y * maxTilt, 0.2f);

//        Quaternion rot = Quaternion.Euler(euler);
//        transform.rotation = Quaternion.Lerp(transform.rotation, rot, sensitivity);

//        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.EulerRotation(0, 0, 1), Time.fixedDeltaTime * 1.5f);

////        Vector3 relativeSpeed = transform.InverseTransformDirection(rigidbody.velocity);
//  //      rigidbody.AddRelativeForce(-relativeSpeed, ForceMode.VelocityChange);


    }
/*
    void Update()
    {








        /////////////////////////////////
        //rotationz = transform.eulerAngles.z;
        //rotationy = transform.eulerAngles.y; 

        //transform.Translate(0, 0, speed/20  * Time.deltaTime);
        //transform.Rotate(0, 0, Time.deltaTime * 100 * (1.0f - rightleftsoftabs - diveblocker) * Input.GetAxis("Horizontal") * -1.0f);

        //transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * 30, 0, Space.World);
        //transform.Rotate(0, Time.deltaTime * 100 * rightleftsoft, 0, Space.World); 

        //if ((Input.GetAxis("Horizontal") <= 0) && (rotationz > 0) && (rotationz < 90)) 
        //    rightleftsoft = rotationz * 2.2f / 100 * -1;

        //if ((Input.GetAxis("Horizontal") >= 0) && (rotationz > 270)) 
        //    rightleftsoft = (7.92f - rotationz * 2.2f / 100);

        //if (rightleftsoft>1) 
        //    rightleftsoft =1;

        //if (rightleftsoft<-1) 
        //    rightleftsoft =-1;
		
        //if ((rightleftsoft>-0.01f) && (rightleftsoft<0.01f)) 
        //    rightleftsoft=0;

        //rightleftsoftabs=Mathf.Abs(rightleftsoft);

        //if ((rotationz < 180) && (Input.GetAxis("Horizontal") > 0)) 
        //    transform.Rotate(0, 0, rightleftsoft * Time.deltaTime * 80);

        //if ((rotationz > 180) && (Input.GetAxis("Horizontal") < 0)) 
        //    transform.Rotate(0, 0, rightleftsoft * Time.deltaTime * 80);


        //if (!Input.GetButton("Horizontal"))
        //{
        //    if ((rotationz < 135)) transform.Rotate(0, 0, rightleftsoftabs * Time.deltaTime * -100);
        //    if ((rotationz > 225)) transform.Rotate(0, 0, rightleftsoftabs * Time.deltaTime * 100);
        //}
        ///////////////////////////////////






        //if (Input.GetKey(KeyCode.LeftArrow))
          //  transform.Rotate(-Vector3.up * speedTurn * Time.deltaTime);

        //if (Input.GetKey(KeyCode.RightArrow))
        //    transform.Rotate(Vector3.up * speedTurn * Time.deltaTime);


        //transform.Rotate(0, 0, Input.GetAxis("Horizontal") * 0.5f);


        //float h = Input.GetAxis("Vertical"); // use the same axis that move back/forth
        //float v = Input.GetAxis("Horizontal"); // use the same axis that turns left/right

        ////print(v);

        //Vector3 vec = transform.localEulerAngles;
        //vec.y = -v * 60;
        //vec.z = h * 45;

        //transform.localEulerAngles.Set(vec.x, vec.y, vec.z);
        //transform.localEulerAngles.x = -v * 60; // forth/back banking first!
        //transform.localEulerAngles.z = h * 45;  // left/right




        //transform.Translate(0, 0, speedZ * Time.deltaTime);



        // move forward with our speed
        //float step = curSpeedZ * Time.deltaTime;
        //Vector3 temp = transform.position;
        //temp.z += step;
        //transform.position = temp;

        //ProcessInput();

        //float h = Input.GetAxis("Vertical"); // use the same axis that move back/forth
        //float v = Input.GetAxis("Horizontal"); // use the same axis that turns left/right

        //transform.localEulerAngles.Set(-v * 60, 0, h * 45);
        //transform.localEulerAngles.x = -v * 60; // forth/back banking first!
        //transform.localEulerAngles.z = h * 45;  // left/right


    }
*/
    void ProcessInput()
    {
        //float step = speedX * Time.deltaTime;
        //bool left = Input.GetKey(KeyCode.LeftArrow);
        //bool right = Input.GetKey(KeyCode.RightArrow);
        //bool up = Input.GetKey(KeyCode.UpArrow);
        //bool down = Input.GetKey(KeyCode.DownArrow);
        //Vector3 temp = transform.position;

        //moveLeft = false;
        //moveRight = false;
        //moveDown = false;
        //moveUp = false;

        //if (left)
        //{
        //    moveLeft = true;
        //}


        //if (right)
        //{
        //    moveRight = true;
        //}


        //if (down)
        //{
        //    moveDown = true;
        //}


        //if (up)
        //{
        //    moveUp = true;
        //}

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
