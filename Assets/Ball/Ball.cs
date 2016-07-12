using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public float fixedVelocity;

	private Rigidbody2D thisRigidbody;
	private Paddle paddle;

	private bool hasBeenLauched = false;

	void Start () {
		thisRigidbody = GetComponent<Rigidbody2D>();
		paddle = GameObject.FindObjectOfType<Paddle>();
	}

	void Update () {
		if(!hasBeenLauched){
			if(Input.GetMouseButtonDown(0)){
				Lauch();
			}

			float ang = (paddle.transform.eulerAngles.z + 135f);
			float radAng = ang * Mathf.Deg2Rad;
			Vector3 dir = new Vector3(Mathf.Cos(radAng), Mathf.Sin(radAng));

			transform.position = dir * 1.2f;

			Vector3 rot = new Vector3(0, 0, ang - 90f);
			transform.eulerAngles = rot;

			return;
		}
		Vector3 vel = thisRigidbody.velocity.normalized;

		if(Mathf.Abs(vel.x) <= 0.01){
			vel.x = Random.Range(-0.3f, 0.3f);
		}
		if(Mathf.Abs(vel.y) <= 0.01){
			vel.y = Random.Range(-0.3f, 0.3f);
		}

		thisRigidbody.velocity = vel * fixedVelocity;
	}

	public void Lauch(){
		hasBeenLauched = true;
		thisRigidbody.AddForce(transform.up * 100f);
	}

}
