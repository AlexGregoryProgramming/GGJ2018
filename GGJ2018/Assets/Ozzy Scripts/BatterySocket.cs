using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterySocket : MonoBehaviour {


	void OnTriggerEnter(Collider otherObject){
		if (otherObject.GetComponent<Battery> () != null) {
			Debug.Log ("I Found a Battery");
			otherObject.GetComponent<Transform> ().position = transform.position;
		}
	}

}
