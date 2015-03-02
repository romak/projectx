using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectReset : MonoBehaviour
{

    Vector3 originalPosition;
    Quaternion originalRotation;
    List<Transform> originalStructure;

    // Use this for initialization
    void Start()
    {
        originalStructure = new List<Transform>(GetComponentsInChildren<Transform>());
        originalPosition = transform.position;
        originalRotation = transform.rotation;
    }

    // Update is called once per frame
    public void ResetAll()
    {
        transform.position = originalPosition;
        transform.rotation = originalRotation;

        if (rigidbody)
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }

        SendMessage("Reset");

    }
}
