using UnityEngine;
using System.Collections;

public class MissileLaunch : MonoBehaviour
{
    public GameObject missile;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
	    	//Vector3 position = new Vector3(0, -0.2f, 1) * 0.5f;
            Vector3 position = new Vector3(-10, -8, -1);
            position = transform.TransformPoint(position);

		    GameObject thisMissile  = (GameObject)Instantiate(missile, position, transform.rotation);
		    Physics.IgnoreCollision(thisMissile.collider, collider);
        }

    }
}
