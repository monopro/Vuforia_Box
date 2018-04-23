using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	public Vector3 rot;
	private float rotSwitch = 1;

	void Update () {

		if (Input.GetKey (KeyCode.Z)) {
			rotSwitch = -1;
		} else {
			rotSwitch = 1;
		}
			
		transform.Rotate (new Vector3 (rot.x, rot.y * rotSwitch, rot.z) * Time.deltaTime);
	}
}
