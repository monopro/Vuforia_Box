using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHit : MonoBehaviour {

	public AudioClip hitsound;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			AudioSource.PlayClipAtPoint (hitsound, transform.position);
		}
	}
}
