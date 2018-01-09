using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Ball;

public class CameraController : MonoBehaviour {

	public float speed = 2.0f;

	private Ball ball;

	// Use this for initialization
	void Start () {
		ball = GameObject.Find ("RollerBall").GetComponent<Ball> ();
	}
	
	// Update is called once per frame
	void Update () {
		float interpolation = speed * Time.deltaTime;
		Vector3 position = transform.position;
		position.x = Mathf.Lerp (transform.position.x, ball.gameObject.transform.position.x, interpolation);
		position.y = Mathf.Lerp (transform.position.y, ball.gameObject.transform.position.y, interpolation);
		position.z = Mathf.Lerp (transform.position.z, ball.gameObject.transform.position.z, interpolation);
		transform.position = position;
	}
}
