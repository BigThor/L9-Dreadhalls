using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnInput : MonoBehaviour {
	[SerializeField] private string SceneName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Submit") == 1 && SceneName != null) {
			SceneManager.LoadScene(SceneName);
		}
	}
}
