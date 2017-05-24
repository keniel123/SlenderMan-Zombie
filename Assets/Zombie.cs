using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {
	AudioSource audioSource;
	public AudioClip comeHere;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();

		audioSource.clip = comeHere;
		audioSource.Play ();

	
	}
	
	// Update is called once per frame
	void Update () {
		
			
		
		} 





}
