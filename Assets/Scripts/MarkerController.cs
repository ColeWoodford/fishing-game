using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerController : MonoBehaviour {

	private Rigidbody2D markerBody;
	private bool stop;
	private Vector3 pos1 = new Vector3 (-8.7f, -3.51f, 0);
	private Vector3 pos2 = new Vector3 (1.71f, -3.51f, 0);

	public float markerSpeed = 1.0f;

	void Start () {
		markerBody = GetComponent<Rigidbody2D>();
		stop = false;
	}

	void Update () {
		MoveCursor (stop);
		//MyInput ();
	}

	void MoveCursor(bool s)
	{
		if (!s) {
			transform.localPosition = Vector3.Lerp (pos1, pos2, (Mathf.Sin (markerSpeed * Time.time) + 1.0f) / 2.0f);
		}
		if (Input.GetKeyDown ("space")) {
			print ("space key was pressed.");
			stop = true;
			//print (markerBody.name);
			//transform.localPosition = Vector3.zero;
		}
	}

	void MyInput()
	{
		if (Input.GetKeyDown ("space")) {
			print ("space key was pressed.");
			print (markerBody.name);
			transform.localPosition = Vector3.zero;
		}
	}
}
