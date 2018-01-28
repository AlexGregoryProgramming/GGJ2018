using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMachine : MonoBehaviour {
	public ProgressControlV3D laserV3D;
	public GameObject lights;
	public bool isFiring = false;
	public GameObject laserCrystal;
	public GameManager gm;
	public Crystal.CrystalColor storedColor;

	public float red = 255.0f;
	public float green = 0.0f;
	public float blue = 0.0f;
	// Use this for initialization
	void Start () {
		//StartCoroutine (RainbowLaser ());
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
					laserCrystal.gameObject.GetComponent<Rigidbody> ().useGravity = false;

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
			collider.gameObject.GetComponent<Rigidbody> ().useGravity = true;
		}
	}

	public IEnumerator LaserFire()
	{
		if (laserCrystal != null) {
			switch (laserCrystal.GetComponent<Crystal> ().color) {
			case Crystal.CrystalColor.Blue:
				laserV3D.finalColor = new Color (0, 0, 255 / 255.0f);
				storedColor = Crystal.CrystalColor.Blue;
				break;

			case Crystal.CrystalColor.BlueGreen:
				laserV3D.finalColor = new Color (0, 255 / 255.0f, 127 / 255.0f);
				storedColor = Crystal.CrystalColor.BlueGreen;
				break;

			case Crystal.CrystalColor.BlueViolet:
				laserV3D.finalColor = new Color (64 / 255.0f, 0, 255 / 255.0f);
				storedColor = Crystal.CrystalColor.BlueViolet;
				break;

			case Crystal.CrystalColor.Green:
				laserV3D.finalColor = new Color (0, 255 / 255.0f, 0);
				storedColor = Crystal.CrystalColor.Green;
				break;

			case Crystal.CrystalColor.Orange:
				laserV3D.finalColor = new Color (255 / 255.0f, 127 / 255.0f, 0);
				storedColor = Crystal.CrystalColor.Orange;
				break;

			case Crystal.CrystalColor.Red:
				laserV3D.finalColor = new Color (255 / 255.0f, 0, 0);
				storedColor = Crystal.CrystalColor.Red;
				break;

			case Crystal.CrystalColor.RedOrange:
				laserV3D.finalColor = new Color (255 / 255.0f, 64 / 255.0f, 0);
				storedColor = Crystal.CrystalColor.RedOrange;
				break;

			case Crystal.CrystalColor.RedViolet:
				laserV3D.finalColor = new Color (191 / 255.0f, 0, 255 / 255.0f);
				storedColor = Crystal.CrystalColor.RedViolet;
				break;

			case Crystal.CrystalColor.Violet:
				laserV3D.finalColor = new Color (127 / 255.0f, 0, 255 / 255.0f);
				storedColor = Crystal.CrystalColor.Violet;
				break;

			case Crystal.CrystalColor.Yellow:
				laserV3D.finalColor = new Color (255 / 255.0f, 255 / 255.0f, 0);
				storedColor = Crystal.CrystalColor.Yellow;
				break;

			case Crystal.CrystalColor.YellowGreen:
				laserV3D.finalColor = new Color (191 / 255.0f, 255 / 255.0f, 0);
				storedColor = Crystal.CrystalColor.YellowGreen;
				break;

			case Crystal.CrystalColor.YellowOrange:
				laserV3D.finalColor = new Color (255 / 255.0f, 191 / 255.0f, 0);
				storedColor = Crystal.CrystalColor.YellowOrange;
				break;
			}
			isFiring = true;
			lights.SetActive (true);
			laserV3D.always = true;

			yield return new WaitForSeconds (5.0f);
			if (gm.checkLaserFire (storedColor)) 
			{
				if (gm.currentLayer == 0) 
				{
					StartCoroutine (RainbowLaser ());
				}
				if (gm.currentLayer != 0) 
				{
					Destroy (laserCrystal);
				}
			}
			if (gm.currentLayer != -1) 
			{
				lights.SetActive (false);
				laserV3D.always = false;
			}


			isFiring = false;
		}




	}


	public IEnumerator RainbowLaser()
	{

		while (true) 
		{
			StartCoroutine (GreenUp ());
			yield return new WaitForSeconds (1.01f);
			StartCoroutine (RedDown ());
			yield return new WaitForSeconds (1.01f);
			StartCoroutine (BlueUp ());
			yield return new WaitForSeconds (1.01f);
			StartCoroutine (GreenDown ());
			yield return new WaitForSeconds (1.01f);
			StartCoroutine (RedUp ());
			yield return new WaitForSeconds (1.01f);
			StartCoroutine (BlueDown ());
			yield return new WaitForSeconds (1.01f);
		}
	}


	public IEnumerator RedUp()
	{
		float time = 0;
		while (time < 1.0f)
		{
			time += Time.deltaTime;
			red += Time.deltaTime* 250.0f;
			yield return new WaitForSeconds (Time.deltaTime);
			laserV3D.finalColor = new Color (red / 255.0f, green / 255.0f, blue / 255.0f);
		}
	}

	public IEnumerator RedDown()
	{
		float time = 0;
		while (time < 1.0f)
		{
			time += Time.deltaTime;
			red -= Time.deltaTime* 250.0f;
			yield return new WaitForSeconds (Time.deltaTime);
			laserV3D.finalColor = new Color (red / 255.0f, green / 255.0f, blue / 255.0f);
		}
	}

	public IEnumerator BlueUp()
	{
		float time = 0;
		while (time < 1.0f)
		{
			time += Time.deltaTime;
			blue += Time.deltaTime* 250.0f;
			yield return new WaitForSeconds (Time.deltaTime);
			laserV3D.finalColor = new Color (red / 255.0f, green / 255.0f, blue / 255.0f);
		}
	}

	public IEnumerator BlueDown()
	{
		float time = 0;
		while (time < 1.0f)
		{
			time += Time.deltaTime;
			blue -= Time.deltaTime * 250.0f;
			yield return new WaitForSeconds (Time.deltaTime);
			laserV3D.finalColor = new Color (red / 255.0f, green / 255.0f, blue / 255.0f);
		}
	}

	public IEnumerator GreenUp()
	{
		float time = 0;
		while (time < 1.0f)
		{
			time += Time.deltaTime;
			green += Time.deltaTime* 250.0f;
			yield return new WaitForSeconds (Time.deltaTime);
			laserV3D.finalColor = new Color (red / 255.0f, green / 255.0f, blue / 255.0f);
		}
	}

	public IEnumerator GreenDown()
	{
		float time = 0;
		while (time < 1.0f)
		{
			time += Time.deltaTime;
			green -= Time.deltaTime* 250.0f;
			yield return new WaitForSeconds (Time.deltaTime);
			laserV3D.finalColor = new Color (red / 255.0f, green / 255.0f, blue / 255.0f);
		}
	}
}
