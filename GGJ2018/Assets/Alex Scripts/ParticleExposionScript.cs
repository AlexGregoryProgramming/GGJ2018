using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleExposionScript : MonoBehaviour {
	public Renderer renderer;
	float value = 0;
	public Texture text;
	// Use this for initialization
	void Start () {
		renderer = GetComponent<Renderer> ();
		renderer.material.shader = Shader.Find ("SineVFX/LivingParticles/LivingParticleAlphaBlended");
		StartCoroutine (Explosion ());
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	public IEnumerator Explosion()
	{
		renderer.material.SetTexture ("_Ramp", text);
		float firstPart = 0.0f;
		while (firstPart < 0.25f) 
		{
			firstPart += Time.deltaTime;
			yield return new WaitForSeconds (Time.deltaTime);
			value += Time.deltaTime * 240;
			renderer.material.SetFloat ("_Distance", value);
		}

		float secondPart = 0.0f;
		value = 4;
		while (secondPart < 0.25f) 
		{
			secondPart += Time.deltaTime;
			yield return new WaitForSeconds (Time.deltaTime);
			value -= Time.deltaTime * 16;
			renderer.material.SetFloat ("_DistancePower", value);
		}
		Destroy (this.gameObject);
	}
}
