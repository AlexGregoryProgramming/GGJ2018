using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffButton : MonoBehaviour {

	public bool isAnimating = false;
	public GameManager gm;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator buttonPress()
	{
		isAnimating = true;
		Vector3 start = this.gameObject.transform.position;
		Vector3 end = new Vector3 (this.gameObject.transform.position.x,this.gameObject.transform.position.y ,this.gameObject.transform.position.z + 0.025f);
		float first = 0.0f;
		float second = 0.0f;
		while (first < 0.2f) 
		{
			yield return new WaitForSeconds (Time.deltaTime);
			first += Time.deltaTime; 
			this.gameObject.transform.position = Vector3.Lerp (start, end, first / 0.2f);
		}

		while (second < 0.5f) 
		{
			yield return new WaitForSeconds (Time.deltaTime);
			second += Time.deltaTime; 
			this.gameObject.transform.position = Vector3.Lerp (end, start, second / 0.5f);

		}
		if (gm.currentLayer == 1) 
		{
			gm.offPressed = true;
		}

		isAnimating = false;
	}
}
