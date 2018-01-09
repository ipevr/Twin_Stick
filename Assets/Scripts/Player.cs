using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float yAxis = CrossPlatformInputManager.GetAxis ("Vertical");
		float xAxis = CrossPlatformInputManager.GetAxis ("Horizontal");
		if (xAxis != 0 || yAxis != 0) {
			Debug.Log ("H: " + xAxis);
			Debug.Log ("V: " + yAxis);
		}
	}
}
