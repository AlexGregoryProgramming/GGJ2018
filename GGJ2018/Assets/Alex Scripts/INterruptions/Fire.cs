using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
	public float firePercentage = 100.0f;
	public GameObject fire1;
	public GameObject fire2;
	public GameObject fire3;
	public GameObject fire4;
	public GameObject fire5;
	public GameObject fire6;
	public GameObject fire7;
	public GameObject fire8;
	public GameObject fire9;
	public GameObject fire10;
	public GameManager gm;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (firePercentage < 90.0f && fire1.activeInHierarchy == true) 
		{
			fire1.SetActive (false);
		}

		if (firePercentage < 80.0f && fire2.activeInHierarchy == true) 
		{
			fire2.SetActive (false);
		}

		if (firePercentage < 70.0f && fire3.activeInHierarchy == true) 
		{
			fire3.SetActive (false);
		}

		if (firePercentage < 60.0f && fire4.activeInHierarchy == true) 
		{
			fire4.SetActive (false);
		}

		if (firePercentage < 50.0f && fire5.activeInHierarchy == true) 
		{
			fire5.SetActive (false);
		}

		if (firePercentage < 40.0f && fire6.activeInHierarchy == true) 
		{
			fire6.SetActive (false);
		}

		if (firePercentage < 30.0f && fire7.activeInHierarchy == true) 
		{
			fire7.SetActive (false);
		}

		if (firePercentage < 20.0f && fire8.activeInHierarchy == true) 
		{
			fire8.SetActive (false);
		}

		if (firePercentage < 10.0f && fire9.activeInHierarchy == true) 
		{
			fire9.SetActive (false);
		}

		if (firePercentage < 0.0f && fire10.activeInHierarchy == true) 
		{
			fire10.SetActive (false);
			gm.fireOut = true;
		}
	}
}
