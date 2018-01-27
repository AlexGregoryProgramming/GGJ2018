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
				
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Violet;
				combinationMade = true;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Yellow) 
			{
				//Orange crystal
				Debug.Log("Orange Crystal");
				
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Orange;
				combinationMade = true;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Violet) 
			{
				//Red-Violet crystal
				Debug.Log("Red-Violet Crystal");
				
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.RedViolet;
				combinationMade = true;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Orange) 
			{
				//Red-Orange crystal
				Debug.Log("Red-Orange Crystal");
				
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
				
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Green;
				combinationMade = true;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Red ) 
			{
				//Orange crystal
				Debug.Log("Orange Crystal");
				
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Orange;
				combinationMade = true;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Green ) 
			{
				//Yellow-Green crystal
				Debug.Log("Yellow-Green Crystal");
				
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.YellowGreen;
				combinationMade = true;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Orange ) 
			{
				//Yellow-Orange crystal
				Debug.Log("Yellow-Orange Crystal");
				
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
				
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Green;
				combinationMade = true;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Red) 
			{
				//purple crystal
				Debug.Log("Purple Crystal");
				
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Violet;
				combinationMade = true;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Green) 
			{
				//Blue-Green crystal
				Debug.Log("Blue-Green Crystal");
				
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.BlueGreen;
				combinationMade = true;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Violet) 
			{
				//Blue-Violet crystal
				Debug.Log("Blue-Violet Crystal");
				
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

				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Violet;
				combinationMade = true;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Yellow) 
			{
				//Orange crystal
				Debug.Log("Orange Crystal");

				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Orange;
				combinationMade = true;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Violet) 
			{
				//Red-Violet crystal
				Debug.Log("Red-Violet Crystal");

				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.RedViolet;
				combinationMade = true;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Orange) 
			{
				//Red-Orange crystal
				Debug.Log("Red-Orange Crystal");

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

				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Green;
				combinationMade = true;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Red ) 
			{
				//Orange crystal
				Debug.Log("Orange Crystal");

				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Orange;
				combinationMade = true;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Green ) 
			{
				//Yellow-Green crystal
				Debug.Log("Yellow-Green Crystal");

				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.YellowGreen;
				combinationMade = true;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Orange ) 
			{
				//Yellow-Orange crystal
				Debug.Log("Yellow-Orange Crystal");

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

				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Green;
				combinationMade = true;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Red) 
			{
				//purple crystal
				Debug.Log("Purple Crystal");

				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Violet;
				combinationMade = true;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Green) 
			{
				//Blue-Green crystal
				Debug.Log("Blue-Green Crystal");

				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				//temp.transform.localScale = new Vector3 (0.11f, 0.11f, 0.11f);
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.BlueGreen;
				combinationMade = true;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Violet) 
			{
				//Blue-Violet crystal
				Debug.Log("Blue-Violet Crystal");

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
			lid.transform.position = lidOff;
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
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Green;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Blue;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.YellowGreen) 
			{
				Destroy (firstCrystal);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Green;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Yellow;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Green) 
			{
				Destroy (firstCrystal);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Yellow;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Blue;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Orange) 
			{
				Destroy (firstCrystal);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Red;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Yellow;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.RedOrange) 
			{
				Destroy (firstCrystal);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Red;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Orange;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.YellowOrange) 
			{
				Destroy (firstCrystal);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Yellow;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Orange;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Violet) 
			{
				Destroy (firstCrystal);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Red;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Blue;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.BlueViolet) 
			{
				Destroy (firstCrystal);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Violet;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Blue;
			}

			if (firstCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.RedViolet) 
			{
				Destroy (firstCrystal);
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
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Green;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Blue;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.YellowGreen) 
			{
				Destroy (secondCrystal);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Green;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Yellow;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Green) 
			{
				Destroy (secondCrystal);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Yellow;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Blue;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Orange) 
			{
				Destroy (secondCrystal);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Red;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Yellow;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.RedOrange) 
			{
				Destroy (secondCrystal);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Red;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Orange;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.YellowOrange) 
			{
				Destroy (secondCrystal);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Yellow;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Orange;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.Violet) 
			{
				Destroy (secondCrystal);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Red;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Blue;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.BlueViolet) 
			{
				Destroy (secondCrystal);
				GameObject temp = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp.GetComponent<Crystal> ().color = Crystal.CrystalColor.Violet;
				GameObject temp2 = Instantiate (crystalPrefab, this.transform.position, Quaternion.identity) as GameObject;
				temp2.GetComponent<Crystal> ().color = Crystal.CrystalColor.Blue;
			}

			if (secondCrystal.GetComponent<Crystal> ().color == Crystal.CrystalColor.RedViolet) 
			{
				Destroy (secondCrystal);
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
		}
		if (firstCrystal != null && secondCrystal != null) {
			CombineCrystals ();
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
				lid.transform.position = lidOn;
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
}
