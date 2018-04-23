using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	public Vector3 rot;
	private float rotateSwitch = 1;
	private float rotateSpeed = 0;
	private bool isRotate = false;

	void Update () {

		if (Input.GetKeyDown (KeyCode.X) && isRotate == false) {
			rotateSpeed = 1;
			isRotate = true;
		} else if (Input.GetKeyDown (KeyCode.X) && isRotate == true) {
			rotateSpeed = 0;
			isRotate = false;
		}

		if (Input.GetKey (KeyCode.Z)) {
			rotateSwitch = -1;
		} else {
			rotateSwitch = 1;
		}
			
		transform.Rotate (new Vector3 (rot.x, rot.y * rotateSwitch, rot.z) * Time.deltaTime * rotateSpeed);
	}
}
