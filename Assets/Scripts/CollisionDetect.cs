using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other) {
		if (other.CompareTag("MarkerTag")) {
			print ("Object Entered the trigger.");
		}
	}
}
