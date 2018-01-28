using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hamster : MonoBehaviour {
	public GameObject water;
	public GameObject food;
	public bool isFed = false;
	public bool isWatered = false;
	public GameManager gm;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isFed == true && isWatered == true) 
		{
			gm.hamsterNeedsMet = true;
		}
	}


	public void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject == water && gm.currentLayer == 3) 
		{
			Destroy (collider.gameObject);
			isWatered = true;
		}

		if (collider.gameObject == food && gm.currentLayer == 3) 
		{
			Destroy (collider.gameObject);
			isFed = true;
		}
	}
}
