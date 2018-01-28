using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {


	public static AudioManager instance = null;
	public AudioSource audioSource;

	[System.Serializable]
	public class AudioObject
	{
		public string clipName;
		public override string ToString() { return clipName; }
		public AudioClip audioClip;
	}

	public AudioObject[] audioObjectArray;
	List<AudioObject> namedAudioObjectArray= new List<AudioObject>();


	void Awake()
	{
		//Check if instance already exists
		if (instance == null)

			//if not, set instance to this
			instance = this;

		//If instance already exists and it's not this:
		else if (instance != this)

			//Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
			Destroy(gameObject);

		//Sets this to not be destroyed when reloading scene
		DontDestroyOnLoad(gameObject);
		// Use this for initialization
	}


	public void playSound(string name , AudioSource source)
	{
		audioSource = source;
		namedAudioObjectArray.Clear ();
		for (int i = 0; i < audioObjectArray.Length; i++)
		{
			if (audioObjectArray [i].clipName == name)
			{
				namedAudioObjectArray.Add (audioObjectArray [i]);
				//print ("added");
			}
		}


		int sound = Random.Range (0, namedAudioObjectArray.Count);
		audioSource.PlayOneShot (namedAudioObjectArray [sound].audioClip, 1.0f);
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
