using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour {

	public MarkerController mark;
	private Vector3 pos;
	private bool win = false;

	// Use this for initialization
	void Start () {
		pos = new Vector3(Random.Range(-8.7f,1.71f),-3.51f,0);
		transform.localPosition = pos;
	}

	void Update() {
		if (mark.getStop ()) {
			WonGame (win);
			enabled = false;
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.CompareTag ("MarkerTag")) {
			win = true;
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		if(other.CompareTag("MarkerTag")) {
			win = false;
		}
	}

	void WonGame(bool w) {
		if (w) {
			print ("YOU WIN!");
		} else {
			print ("You lose.");
		}
	}
}
