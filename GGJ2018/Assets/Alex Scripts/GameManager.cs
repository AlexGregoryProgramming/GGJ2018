using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public Crystal.CrystalColor layer1Color;
	public Crystal.CrystalColor layer2Color;
	public Crystal.CrystalColor layer3Color;
	public Crystal.CrystalColor layer4Color;
	public int currentLayer = 4;

	public GameObject layer1;
	public GameObject layer2;
	public GameObject layer3;
	public GameObject layer4;

	public GameObject layer1Explosion;
	public GameObject layer2Explosion;
	public GameObject layer3Explosion;
	public GameObject layer4Explosion;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void checkLaserFire(Crystal.CrystalColor color)
	{
		if (currentLayer == 4) 
		{
			if (layer4Color == color) 
			{
				layer4Explosion.SetActive (true);
				currentLayer = 3;
				layer4.SetActive (false);
				layer3.SetActive (true);
			}
		}
		else if (currentLayer == 3) 
		{
			if (layer3Color == color) 
			{
				layer3Explosion.SetActive (true);
				currentLayer = 2;
				layer3.SetActive (false);
				layer2.SetActive (true);
			}
		}
		else if (currentLayer == 2) 
		{
			if (layer2Color == color) 
			{
				layer2Explosion.SetActive (true);
				currentLayer = 1;
				layer2.SetActive (false);
				layer1.SetActive (true);
			}
		}
		else if (currentLayer == 1) 
		{
			if (layer1Color == color) 
			{
				layer1Explosion.SetActive (true);
				currentLayer = 0;
				layer1.SetActive (false);
			}
		}
		else
		{
			//Boom!
		}
	}
}
