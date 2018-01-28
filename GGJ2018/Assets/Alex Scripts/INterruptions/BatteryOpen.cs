using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryOpen : MonoBehaviour {
	public GameObject panel;
	// Use this for initialization
	void Start () {
		//StartCoroutine (openPanel ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public IEnumerator openPanel()
	{
		float startAngle = 0.0f;
		float endAngle = -90.0f;

		float first = 0.0f;
		while (first < 0.5f) 
		{
			yield return new WaitForSeconds (Time.deltaTime);
			first += Time.deltaTime; 
			float angle = Mathf.LerpAngle (startAngle, endAngle, first / 0.5f);
			panel.transform.eulerAngles = new Vector3 (angle, 0, 0);
		}
	}

	public IEnumerator closePanel()
	{
		float startAngle = -90.0f;
		float endAngle = 0.0f;

		float second = 0.0f;
		while (second < 0.5f) 
		{
			yield return new WaitForSeconds (Time.deltaTime);
			second += Time.deltaTime; 
			float angle = Mathf.LerpAngle (startAngle, endAngle, second / 0.5f);
			panel.transform.eulerAngles = new Vector3 (angle, 0, 0);

		}
	}
}
