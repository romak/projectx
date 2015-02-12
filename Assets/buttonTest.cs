using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttonTest : MonoBehaviour {

    public Slider slider;


    public void DoSomething()
    {
        Debug.Log(slider.value.ToString());
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
