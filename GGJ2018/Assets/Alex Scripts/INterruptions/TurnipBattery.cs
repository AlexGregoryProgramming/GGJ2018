using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnipBattery : MonoBehaviour {
	public bool oldTurnipGone = false;
	public bool newTurnipIn = false;
	public GameObject secretTurnip;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.GetComponent<GoodTurnip> () != null) 
		{
			newTurnipIn = true;
			Destroy (collider.gameObject);
			secretTurnip.SetActive (true);


		}
	}

	public void OnTriggerExit(Collider collider)
	{
		if (collider.gameObject.GetComponent<BadTurnip> () != null) 
		{
			oldTurnipGone = true;
		}
	}
}
