using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	public Vector3 rot;

	void Update () {
		transform.Rotate (new Vector3 (rot.x, rot.y, rot.z) * Time.deltaTime);
	}
}
