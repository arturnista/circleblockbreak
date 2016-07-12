using UnityEngine;
using System.Collections;

public class EndCicle : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll){
		Ball ball = coll.collider.GetComponent<Ball>();
		if(ball){
			print("Perdeu vida!");
		}
	}
}
