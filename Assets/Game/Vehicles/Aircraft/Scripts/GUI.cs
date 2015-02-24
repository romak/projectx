using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUI : MonoBehaviour {

    public Text guiText;
    public AircraftController plane;

    private const float MpsToKph = 3.6f;        // Constant for converting metres per second to kilometres per hour.
    private string displayText = "Throttle: {0:0%}\nSpeed: {1:0000}KM/H\nAltitude: {2:0000}M";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        object[] args = new object[] { plane.Throttle, plane.ForwardSpeed * MpsToKph, plane.Altitude };

        // display the aeroplane gui information
        guiText.text = string.Format(displayText, args);

        //guiText.text = plane.RollAngle.ToString();
        guiText.text = plane.PitchAngle.ToString();
	
	}
}
