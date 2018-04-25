using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualRotate : MonoBehaviour {

	void Start(){

		// カーソルを非表示にしてロックをかける。
		Cursor.lockState = CursorLockMode.Locked;
	}

	void Update () {
		transform.Rotate (0, Input.GetAxis ("Mouse X") * 2, 0);
	}
}
