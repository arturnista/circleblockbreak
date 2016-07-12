using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	[Range(1, 5)]
	public int hitNumber;

	private int currentLife;
	private GameController gc;

	void Awake(){
		currentLife = hitNumber;
		gc = GameObject.FindObjectOfType<GameController>();
	}

	void OnCollisionEnter2D(Collision2D coll){
		Ball ball = coll.collider.GetComponent<Ball>();
		if(ball){
			currentLife--;
			if(currentLife <= 0){
				Invoke("DestroyBlock", 0.1f);
			}
		}
	}

	void DestroyBlock(){
		Destroy(this.gameObject);
		gc.BlockDestroyed();
	}

}
