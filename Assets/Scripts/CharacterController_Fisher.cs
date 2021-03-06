using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController_Fisher : MonoBehaviour {

	public float speed = 10.0f;

	void Update()
	{
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		var y = Input.GetAxis("Vertical") * Time.deltaTime * speed;

		transform.Translate(x, 0, 0);
		transform.Translate(0, y, 0);
	}

}
