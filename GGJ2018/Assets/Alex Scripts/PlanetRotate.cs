using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotate : MonoBehaviour {
	public GameObject rotator;
	public float speed;
	// Use this for initialization
	void Start () {
		rotator = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		rotator.transform.Rotate (Vector3.up, - speed * Time.deltaTime);
	}
}
