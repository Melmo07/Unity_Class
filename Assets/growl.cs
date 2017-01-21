using UnityEngine;
using System.Collections;

public class growl : MonoBehaviour {

	public bool Alreadyplay;
	public AudioSource soundSource;

	// Use this for initialization
	void Start () {
		soundSource = GetComponent<AudioSource> ();
		Alreadyplay = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider trigger) {
		if (!Alreadyplay && trigger.gameObject.name =="FPSconrtoller") {
		soundSource.Play();
			Alreadyplay = true;
		}
	}
}
