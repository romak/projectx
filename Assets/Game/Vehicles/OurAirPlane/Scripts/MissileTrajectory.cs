using UnityEngine;
using System.Collections;

public class MissileTrajectory : MonoBehaviour
{
    public float speed = 60.0f;
    public ParticleSystem ps;
    GameObject target;
    GameObject lastTarget;

    void Start()
    {
        //target = FindClosestEnemy("enemy");
    }

    GameObject FindClosestEnemy(string tag)
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag(tag);
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;

        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;

            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }

    void Update()
    {

        if (target != null)
        {
            //print(target.name);
            Vector3 relativePos = target.transform.position - transform.position;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(relativePos), speed * Time.deltaTime);
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * speed);
        target = FindClosestEnemy("enemy");

        if (target != null)
        {
            //print(target.name);
            Vector3 relativePos = target.transform.position - transform.position;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(relativePos), speed * Time.deltaTime);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        //Destroy(gameObject);
        //Destroy(this);

    }

    IEnumerator DoSomething()
    {
        Destroy(gameObject);
        yield return new WaitForSeconds(1f);

    }

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];

        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
        }

        //print(collision.gameObject.name);
        //DoSomething();
        Destroy(gameObject);
        //Destroy(this);
    }

}
