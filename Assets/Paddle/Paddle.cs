using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public float speed = 10f;
	public float clickedSpeed = 20f;

	private float currentSpeed;
	private float signSpeed = 1f;

	void Start () {
		currentSpeed = speed;
	}

	void Update () {
		if(Input.GetMouseButtonDown(0)){
			signSpeed *= -1;
		}
		if(Input.GetMouseButton(0)){
			currentSpeed = clickedSpeed;
		} else {
			currentSpeed = speed;
		}

		transform.RotateAround(transform.position, new Vector3(0,0,1f), signSpeed * currentSpeed * Time.deltaTime);
	}
}
