using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMachine : MonoBehaviour {
	public ProgressControlV3D laserV3D;
	public bool isFiring = false;
	public GameObject laserCrystal;
	public GameManager gm;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider collider)
	{

			if (collider.gameObject.GetComponent<Crystal> () != null) 
			{
				if (laserCrystal == null) {
					laserCrystal = collider.gameObject;


				} else {
					collider.gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (Random.Range (0.5f, 1.0f), 1, Random.Range (0.5f, 1.0f) * 2000));
				}
				Debug.Log ("Crystal Added");
			}

	}

	void OnTriggerExit(Collider collider)
	{
		if (collider.gameObject == laserCrystal) 
		{
			laserCrystal = null;
		}
	}

	public IEnumerator LaserFire()
	{
		switch (laserCrystal.GetComponent<Crystal> ().color) 
		{
		case Crystal.CrystalColor.Blue:
			laserV3D.finalColor = new Color (0, 0, 255 / 255.0f);
			break;

		case Crystal.CrystalColor.BlueGreen:
			laserV3D.finalColor = new Color (0, 255 / 255.0f, 127 / 255.0f);
			break;

		case Crystal.CrystalColor.BlueViolet:
			laserV3D.finalColor = new Color (64 / 255.0f, 0, 255 / 255.0f);
			break;

		case Crystal.CrystalColor.Green:
			laserV3D.finalColor = new Color (0, 255 / 255.0f, 0);
			break;

		case Crystal.CrystalColor.Orange:
			laserV3D.finalColor = new Color (255 / 255.0f, 127 / 255.0f, 0);
			break;

		case Crystal.CrystalColor.Red:
			laserV3D.finalColor = new Color (255 / 255.0f, 0, 0);
			break;

		case Crystal.CrystalColor.RedOrange:
			laserV3D.finalColor = new Color (255 / 255.0f, 64 / 255.0f, 0);
			break;

		case Crystal.CrystalColor.RedViolet:
			laserV3D.finalColor = new Color (191 / 255.0f, 0, 255 / 255.0f);
			break;

		case Crystal.CrystalColor.Violet:
			laserV3D.finalColor = new Color (127 / 255.0f, 0, 255 / 255.0f);
			break;

		case Crystal.CrystalColor.Yellow:
			laserV3D.finalColor = new Color (255 / 255.0f, 255 / 255.0f, 0);
			break;

		case Crystal.CrystalColor.YellowGreen:
			laserV3D.finalColor = new Color (191 / 255.0f, 255 / 255.0f, 0);
			break;

		case Crystal.CrystalColor.YellowOrange:
			laserV3D.finalColor = new Color (255 / 255.0f, 191 / 255.0f, 0);
			break;
		}
		isFiring = true;
		laserV3D.always = true;
		yield return new WaitForSeconds (5.0f);
		gm.checkLaserFire(laserCrystal.GetComponent<Crystal> ().color);
		laserV3D.always = false;
		isFiring = false;
	}
}
