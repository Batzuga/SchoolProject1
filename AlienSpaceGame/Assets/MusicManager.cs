using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    private AudioSource audioSource;

	void Awake ()
    {
        audioSource = GameObject.Find("ScriptBlock").GetComponent<AudioSource>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
