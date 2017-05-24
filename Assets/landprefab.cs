using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landprefab : MonoBehaviour {
	public float timeSince = 0f;
	AudioSource audioSource;
	public AudioClip zombieSpawn;
	public AudioClip zombiechase;
	bool alreadyPlaying = false;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
		audioSource.clip = zombieSpawn;
		audioSource.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		timeSince += Time.deltaTime;

		if (alreadyPlaying == false && timeSince > 10f) {
			audioSource.spatialBlend = 1.0f;
			audioSource.minDistance = 20;
			audioSource.maxDistance = 650;
			audioSource.clip = zombiechase;
			audioSource.loop = true;
			audioSource.Play ();
			alreadyPlaying = true;

		}
	}
}
