using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour {
	public float intervalTime = 2f;

	void Start() {
	}

	void OnEnable () {
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	void OnSceneLoaded (Scene scene, LoadSceneMode mode)
	{
		if (scene.buildIndex == 0) {
			AutoLoadNextScene();
		}
	}

	void OnDisable () {
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}

	public void LoadScene (string level) {
		SceneManager.LoadScene(level);
	}

	public void LoadNextScene () {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	void AutoLoadNextScene () {
		Invoke("LoadNextScene", intervalTime);
	}	
}
