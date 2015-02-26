using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SmoothFollow))]
public class FollowCamera : MonoBehaviour
{

    public Transform target;
    public float distance = 10.0f;

    void LateUpdate()
    {

        if (!target)
            return;

        Vector3 hg = transform.position;
        hg.z = target.position.z - distance;
        transform.position = hg;






/*
        wantedRotationAngle = target.eulerAngles.y;
        wantedHeight = target.position.y + height;

        currentRotationAngle = transform.eulerAngles.y;
        currentHeight = transform.position.y;

        // Damp the rotation around the y-axis
        currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);

        // Damp the height
        currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

        // Convert the angle into a rotation
        currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

        transform.position = target.position;
        transform.position -= currentRotation * Vector3.forward * distance;

        // Set the height of the camera

        Vector3 hg = transform.position;
        hg.y = currentHeight;
        transform.position.Set(hg.x,hg.y,hg.z);

        // Always look at the target
        transform.LookAt(target);
*/
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
