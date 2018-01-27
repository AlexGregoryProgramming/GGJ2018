using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamsterCage : MonoBehaviour {
	public float destructionDelay = 0.15f;

	void OnTriggerEnter(Collider otherObject){
		if (otherObject.GetComponent<WaterBottle> () != null) {
			Destroy (otherObject.gameObject, destructionDelay);
			Debug.Log ("Hamster has Water");
		}
	}
}
