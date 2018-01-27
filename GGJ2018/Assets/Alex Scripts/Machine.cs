using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine : MonoBehaviour {
	public GameObject firstCrystal;
	public GameObject secondCrystal;
	public GameObject lid;
	public Vector3 lidOn;
	public Vector3 lidOff;
	public bool combinationMade;
	public GameObject crystalPrefab;

	public GameObject particleObject;
	public GameObject affector;
	public Vector3 affectorUp;
	public Vector3 affectorDown;
	public Color crystalCreationColor;

	public bool isMachineRunning = false;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void CombineCrystals()
	{
		//First Crystal Check
		//Red Crystal
		if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Red && combinationMade == false) 
		{
			Debug.Log ("Red Crystal");
			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Blue) 
			{
				//purple crystal
				Debug.Log("Purple Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (127/255.0f, 0, 255/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Violet;
				combinationMade = true;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Yellow) 
			{
				//Orange crystal
				Debug.Log("Orange Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (255/255.0f, 127/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Orange;
				combinationMade = true;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Violet) 
			{
				//Red-Violet crystal
				Debug.Log("Red-Violet Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (191/255.0f, 0, 255/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.RedViolet;
				combinationMade = true;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Orange) 
			{
				//Red-Orange crystal
				Debug.Log("Red-Orange Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (255/255.0f, 64/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.RedOrange;
				combinationMade = true;
			}
		}

		//Yellow Crystal
		if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Yellow && combinationMade == false) 
		{
			Debug.Log ("Yellow Crystal");
			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Blue ) 
			{
				//Green crystal
				Debug.Log("Green Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (0, 255/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Green;
				combinationMade = true;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Red ) 
			{
				//Orange crystal
				Debug.Log("Orange Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (255/255.0f, 127/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Orange;
				combinationMade = true;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Green ) 
			{
				//Yellow-Green crystal
				Debug.Log("Yellow-Green Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (191/255.0f, 255/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.YellowGreen;
				combinationMade = true;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Orange ) 
			{
				//Yellow-Orange crystal
				Debug.Log("Yellow-Orange Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (255/255.0f, 191/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.YellowOrange;
				combinationMade = true;
			}
		}

		//Blue Crystal
		if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Blue && combinationMade == false) 
		{
			Debug.Log ("Blue Crystal");
			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Yellow) 
			{
				//Green crystal
				Debug.Log("Green Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (0, 255/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Green;
				combinationMade = true;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Red) 
			{
				//purple crystal
				Debug.Log("Purple Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (127/255.0f, 0, 255/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Violet;
				combinationMade = true;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Green) 
			{
				//Blue-Green crystal
				Debug.Log("Blue-Green Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (0, 255/255.0f, 127/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.BlueGreen;
				combinationMade = true;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Violet) 
			{
				//Blue-Violet crystal
				Debug.Log("Blue-Violet Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (64/255.0f, 0, 255/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.BlueViolet;
				combinationMade = true;
			}
		}


		//second crystal check

		//Red Crystal
		if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Red && combinationMade == false) 
		{
			Debug.Log ("Red Crystal");
			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Blue) 
			{
				//purple crystal
				Debug.Log("Purple Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (127/255.0f, 0, 255/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Violet;
				combinationMade = true;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Yellow) 
			{
				//Orange crystal
				Debug.Log("Orange Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (255/255.0f, 127/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Orange;
				combinationMade = true;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Violet) 
			{
				//Red-Violet crystal
				Debug.Log("Red-Violet Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (191/255.0f, 0, 255/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.RedViolet;
				combinationMade = true;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Orange) 
			{
				//Red-Orange crystal
				Debug.Log("Red-Orange Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (255/255.0f, 64/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.RedOrange;
				combinationMade = true;
			}
		}

		//Yellow Crystal
		if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Yellow && combinationMade == false) 
		{
			Debug.Log ("Yellow Crystal");
			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Blue ) 
			{
				//Green crystal
				Debug.Log("Green Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (0, 255/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Green;
				combinationMade = true;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Red ) 
			{
				//Orange crystal
				Debug.Log("Orange Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (255/255.0f, 127/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Orange;
				combinationMade = true;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Green ) 
			{
				//Yellow-Green crystal
				Debug.Log("Yellow-Green Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor = new Color (191/255.0f, 255/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.YellowGreen;
				combinationMade = true;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Orange ) 
			{
				//Yellow-Orange crystal
				Debug.Log("Yellow-Orange Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor = new Color (255/255.0f, 191/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.YellowOrange;
				combinationMade = true;
			}
		}

		//Blue Crystal
		if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Blue && combinationMade == false) 
		{
			Debug.Log ("Blue Crystal");
			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Yellow) 
			{
				//Green crystal
				Debug.Log("Green Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor = new Color (0, 0, 255/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Green;
				combinationMade = true;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Red) 
			{
				//purple crystal
				Debug.Log("Purple Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor = new Color (127/255.0f, 0, 255/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Violet;
				combinationMade = true;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Green) 
			{
				//Blue-Green crystal
				Debug.Log("Blue-Green Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (0, 255/255.0f, 127/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.BlueGreen;
				combinationMade = true;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Violet) 
			{
				//Blue-Violet crystal
				Debug.Log("Blue-Violet Crystal");
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor = new Color (64/255.0f, 0, 255/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.BlueViolet;
				combinationMade = true;
			}
		}


		if (combinationMade == true) 
		{
			//destroy crystals
			Destroy(firstCrystal);
			Destroy (secondCrystal);
			//lid.transform.position = lidOff;
			combinationMade = false;
		} 
		else
		{
			//spit them back out.
		}
	}
	//combines the crystals
	public void SplitCrystals()
	{
		if(firstCrystal != null && secondCrystal == null)
			{
			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.BlueGreen) 
			{
				Destroy (firstCrystal);

				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (0, 255/255.0f, 127/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Green;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Blue;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.YellowGreen) 
			{
				Destroy (firstCrystal);
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor = new Color (191/255.0f, 255/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Green;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Yellow;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Green) 
			{
				Destroy (firstCrystal);

				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (0, 255/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Yellow;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Blue;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Orange) 
			{
				Destroy (firstCrystal);

				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (255/255.0f, 127/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Red;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Yellow;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.RedOrange) 
			{
				Destroy (firstCrystal);

				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (255/255.0f, 64/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Red;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Orange;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.YellowOrange) 
			{
				Destroy (firstCrystal);
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor = new Color (255/255.0f, 191/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Yellow;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Orange;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Violet) 
			{
				Destroy (firstCrystal);

				particleObject.GetComponent<ParticleGridGenerator> ().particleColor = new Color (127/255.0f, 0, 255/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Red;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Blue;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.BlueViolet) 
			{
				Destroy (firstCrystal);
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor = new Color (64/255.0f, 0, 255/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Violet;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Blue;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.RedViolet) 
			{
				Destroy (firstCrystal);

				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (191/255.0f, 0, 255/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Red;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Violet;
			}
			}


		if(firstCrystal == null && secondCrystal != null)
		{
			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.BlueGreen) 
			{
				Destroy (secondCrystal);

				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (0, 255/255.0f, 127/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Green;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Blue;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.YellowGreen) 
			{
				Destroy (secondCrystal);
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor = new Color (191/255.0f, 255/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Green;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Yellow;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Green) 
			{
				Destroy (secondCrystal);

				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (0, 255/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Yellow;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Blue;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Orange) 
			{
				Destroy (secondCrystal);

				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (255/255.0f, 127/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Red;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Yellow;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.RedOrange) 
			{
				Destroy (secondCrystal);

				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (255/255.0f, 64/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Red;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Orange;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.YellowOrange) 
			{
				Destroy (secondCrystal);
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor = new Color (255/255.0f, 191/255.0f, 0);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Yellow;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Orange;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Violet) 
			{
				Destroy (secondCrystal);

				particleObject.GetComponent<ParticleGridGenerator> ().particleColor = new Color (127/255.0f, 0, 255/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Red;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Blue;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.BlueViolet) 
			{
				Destroy (secondCrystal);
				particleObject.GetComponent<ParticleGridGenerator> ().particleColor = new Color (64/255.0f, 0, 255/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Violet;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Blue;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.RedViolet) 
			{
				Destroy (secondCrystal);

				particleObject.GetComponent<ParticleGridGenerator> ().particleColor =new Color (191/255.0f, 0, 255/255.0f);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Red;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Violet;
			}
		}
	}
	public void buttonPress()
	{
		if ((firstCrystal != null && secondCrystal == null) || (firstCrystal == null && secondCrystal != null)) 
		{
			SplitCrystals ();
			StartCoroutine (showParticlesSplit ());
		}
		if (firstCrystal != null && secondCrystal != null) {
			CombineCrystals ();
			StartCoroutine (showParticlesCombine ());
		}
	}
	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.GetComponent<Crystal> () != null) 
		{
			if (firstCrystal == null) 
			{
				firstCrystal = collider.gameObject;
			} 
			else if (secondCrystal == null) 
			{
				secondCrystal = collider.gameObject;
				//lid.transform.position = lidOn;
				//CombineCrystals ();
			} 
			else 
			{
				collider.gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3(Random.Range(0.5f,1.0f),1,Random.Range(0.5f,1.0f) * 2000));
			}
			Debug.Log ("Crystal Added");
		}
	}

	void OnTriggerExit(Collider collider)
	{
		if (collider.gameObject == firstCrystal) 
		{
			firstCrystal = null;
		}

		if (collider.gameObject == secondCrystal) 
		{
			secondCrystal = null;
		}
	}

	public IEnumerator SlideLid(float time)
	{
		isMachineRunning = true;
		float firstDuration = 0.0f;
		float secondDuration = 0.0f;
		lidOff = lid.transform.position;
		lidOn = new Vector3 (lid.transform.position.x, lid.transform.position.y, lid.transform.position.z + 0.65f);
		while (firstDuration < time) 
		{
			lid.transform.position = Vector3.Lerp (lidOff, lidOn, firstDuration / time);
			firstDuration += Time.deltaTime;
			yield return new WaitForSeconds (Time.deltaTime);
		}
		buttonPress ();
		//particleObject.GetComponent<ParticleGridGenerator> ().particleColor = crystalCreationColor;
		yield return new WaitForSeconds (0.5f);

		yield return new WaitForSeconds (0.5f);

		while (secondDuration < time) 
		{
			lid.transform.position = Vector3.Lerp (lidOn, lidOff, secondDuration / time);
			secondDuration += Time.deltaTime;
			yield return new WaitForSeconds (Time.deltaTime);
		}
		isMachineRunning = false;
		yield return null;
	}

	public IEnumerator showParticlesCombine()
	{

		affector.transform.position = affectorUp;
		float particleTimer = 0.0f;
		particleObject.SetActive (true);
		while (particleTimer < 0.5f) 
		{

			affector.transform.position = Vector3.Lerp (affectorUp, affectorDown, particleTimer / 0.5f);
			particleTimer += Time.deltaTime;
			yield return new WaitForSeconds (Time.deltaTime);
		}
		affector.transform.position = affectorUp;
		particleObject.SetActive (false);
	}

	public IEnumerator showParticlesSplit()
	{

		float particleTimer = 0.0f;
		affector.transform.position = affectorDown;
		particleObject.SetActive (true);
		while (particleTimer < 0.5f) 
		{

			affector.transform.position = Vector3.Lerp (affectorDown, affectorUp, particleTimer / 0.5f);
			particleTimer += Time.deltaTime;
			yield return new WaitForSeconds (Time.deltaTime);
		}
		affector.transform.position = affectorUp;
		particleObject.SetActive (false);
	}
}
