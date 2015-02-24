using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AircraftController))]
public class AircraftRestrictions : MonoBehaviour
{

    [SerializeField]
    float maxClimbAngle = 45;                        // The maximum angle that the AI will attempt to make plane can climb at
    [SerializeField]
    float maxRollAngle = 45;                         // The maximum angle that the AI will attempt to u

    private AircraftController aeroplaneController;           // The aeroplane controller that is used to move the plane
    private float randomPerlin;                                // Used for generating random point on perlin noise so that the plane will wander off path slightly
    private bool takenOff;                               		// Has the plane taken off yet

    void Awake()
    {
        // get the reference to the aeroplane controller, so we can send move input to it and read its current state.
        aeroplaneController = GetComponent<AircraftController>();

        // pick a random perlin starting point for lateral wandering
        randomPerlin = Random.Range(0f, 100f);
    }

    // reset the object to sensible values
    public void Reset()
    {
        takenOff = false;
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

    }
}
