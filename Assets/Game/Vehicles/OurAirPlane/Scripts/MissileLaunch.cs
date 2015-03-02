using UnityEngine;
using System.Collections;

public class MissileLaunch : MonoBehaviour
{
    public GameObject missile;
    public Transform missilePos;
    public float fireRate = 1.0f;
    private float nextFire;

    void Start()
    {

    }

    public void FireRocket()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject thisMissile = (GameObject)Instantiate(missile, missilePos.position, transform.rotation);
            Physics.IgnoreCollision(thisMissile.collider, collider);
        }
    }


    void Update()
    {
        //if ((Input.GetKeyDown(KeyCode.Space) || (Input.GetButton("Fire1"))) && (Time.time > nextFire))
        if ((Input.GetKeyDown(KeyCode.Space)))
        {
            FireRocket();
        }

    }
}
