using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public Crystal.CrystalColor layer1Color;
	public Crystal.CrystalColor layer2Color;
	public Crystal.CrystalColor layer3Color;
	public Crystal.CrystalColor layer4Color;
	public int currentLayer = 4;
	public GameObject planet;
	public GameObject layer1;
	public GameObject layer2;
	public GameObject layer3;
	public GameObject layer4;


	public GameObject planetExplosion;
	public GameObject layer1Explosion;
	public GameObject layer2Explosion;
	public GameObject layer3Explosion;
	public GameObject layer4Explosion;

	public GameObject fire;
	public bool hamsterNeedsMet = false;
	public bool fireOut = false;
	public bool generatorRestarted = false;
	public bool batteryReplaced = false;
	public bool isInterrupted = false;

	public bool offPressed;
	public bool onPressed;

	public BatteryOpen batteryOpen;
	public TurnipBattery battery;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (currentLayer == 3 && isInterrupted == true && hamsterNeedsMet == true) 
		{
			isInterrupted = false;
		}

		if (currentLayer == 2 && isInterrupted == true && fireOut == true) 
		{
			isInterrupted = false;
		}

		if (currentLayer == 1 && isInterrupted == true && generatorRestarted == true) 
		{
			isInterrupted = false;
		}

		if (currentLayer == 0 && isInterrupted == true && batteryReplaced == true) 
		{
			isInterrupted = false;
		}


		if (offPressed == true && onPressed == true && generatorRestarted == false) {
			generatorRestarted = true;
			isInterrupted = false;
			batteryOpen.StartCoroutine (batteryOpen.openPanel ());
		}

		if (battery.oldTurnipGone == true && battery.newTurnipIn == true && batteryReplaced == false) {
			batteryReplaced = true;
			isInterrupted = false;
			batteryOpen.StartCoroutine (batteryOpen.closePanel ());
		}
	}

	public bool checkLaserFire(Crystal.CrystalColor color)
	{
		if (currentLayer == 4) {
			if (layer4Color == color) {
				layer4Explosion.SetActive (true);
				currentLayer = 3;
				layer4.SetActive (false);
				layer3.SetActive (true);
				isInterrupted = true; // cannot continue until you do the interruption
				// hampster go!
				return true;
			}
		} else if (currentLayer == 3) {
			if (layer3Color == color) {
				layer3Explosion.SetActive (true);
				currentLayer = 2;
				layer3.SetActive (false);
				layer2.SetActive (true);
				isInterrupted = true; // cannot continue until you do the interruption
				fire.SetActive(true);
				return true;
			}
		} else if (currentLayer == 2) {
			if (layer2Color == color) {
				layer2Explosion.SetActive (true);
				currentLayer = 1;
				layer2.SetActive (false);
				layer1.SetActive (true);
				isInterrupted = true; // cannot continue until you do the interruption
				return true;
			}
		} else if (currentLayer == 1) 
		{
			if (layer1Color == color) 
			{
				layer1Explosion.SetActive (true);
				currentLayer = 0;
				layer1.SetActive (false);
				isInterrupted = true; // cannot continue until you do the interruption
				batteryOpen.StartCoroutine(batteryOpen.openPanel());
				return true;
			}
		}
		else if (currentLayer == 0) 
		{
			planetExplosion.SetActive (true);
			currentLayer = -1;
			planet.SetActive (false);
			return true;
			//rainbow laser for final shot?
		} 
		else 
		{
			return false;	
		}
		return false;
	}
}
