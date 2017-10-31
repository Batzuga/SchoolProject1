using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public string levelName;
    private Scene scene;
    void Awake()
    {
        scene = SceneManager.GetActiveScene();
        levelName = scene.name;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
