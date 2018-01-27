using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour 
{
	public enum CrystalColor{Red,RedOrange,Orange,YellowOrange,Yellow,YellowGreen,Green,BlueGreen,Blue,BlueViolet,Violet,RedViolet};
	public CrystalColor color;
	public Material material;

	// Use this for initialization
	void Start () 
	{
		material = this.gameObject.GetComponent<MeshRenderer> ().material;

		switch (color) 
		{
		case CrystalColor.Blue:
			material.color = new Color (0, 0, 255/255.0f);
			break;

		case CrystalColor.BlueGreen:
			material.color = new Color (0, 255/255.0f, 127/255.0f);
			break;

		case CrystalColor.BlueViolet:
			material.color = new Color (64/255.0f, 0, 255/255.0f);
			break;

		case CrystalColor.Green:
			material.color = new Color (0, 255/255.0f, 0);
			break;

		case CrystalColor.Orange:
			material.color = new Color (255/255.0f, 127/255.0f, 0);
			break;

		case CrystalColor.Red:
			material.color = new Color (255/255.0f, 0, 0);
			break;

		case CrystalColor.RedOrange:
			material.color = new Color (255/255.0f, 64/255.0f, 0);
			break;

		case CrystalColor.RedViolet:
			material.color = new Color (191/255.0f, 0, 255/255.0f);
			break;

		case CrystalColor.Violet:
			material.color = new Color (127/255.0f, 0, 255/255.0f);
			break;

		case CrystalColor.Yellow:
			material.color = new Color (255/255.0f, 255/255.0f, 0);
			break;

		case CrystalColor.YellowGreen:
			material.color = new Color (191/255.0f, 255/255.0f, 0);
			break;

		case CrystalColor.YellowOrange:
			material.color = new Color (255/255.0f, 191/255.0f, 0);
			break;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
