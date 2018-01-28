using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extinguisher : MonoBehaviour {
	public GameManager gm;
	public RaycastHit hit;
	public GameObject particles;
	public bool trigger = false;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gm.currentLayer == 2 && trigger == false) 
		{
			particles.SetActive (true);
			trigger = true;
		}
		if (gm.currentLayer == 2 && gm.fireOut == false) 
		{
			if (Physics.Raycast (this.gameObject.transform.position, this.gameObject.transform.forward, out hit)) {
				if (hit.collider.gameObject.GetComponent<Fire> () != null) {
					Debug.Log ("Fire");
					hit.collider.gameObject.GetComponent<Fire> ().firePercentage -= 20 * Time.deltaTime;
				}
			}
		} 
		else 
		{
			particles.SetActive (false);
		}
	}
}
