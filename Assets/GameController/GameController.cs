using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private bool botNotCleaned = true;
	private bool topNotCleaned = true;

	private bool gameEnd = false;

	void Start () {

	}

	void Update () {
	}

	public void BlockDestroyed(){
		GameObject[] blocks = GameObject.FindGameObjectsWithTag("Block");

		if(blocks.Length <= 0){
			Restart();
			return;
		}

		botNotCleaned = false;
		topNotCleaned = false;
		foreach(GameObject go in blocks){
			if(go.transform.position.y > 0){
				topNotCleaned = true;
			}
			if(go.transform.position.y < 0){
				botNotCleaned = true;
			}
		}
	}

	void Restart(){

	}
}
