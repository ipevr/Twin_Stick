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
		float yAxis = Input.GetAxis ("Vertical");
		float xAxis = Input.GetAxis ("Horizontal");
		if (xAxis != 0 || yAxis != 0) {
			print (xAxis + " " + yAxis);
		}
	}
}
