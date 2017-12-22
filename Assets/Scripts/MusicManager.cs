using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MusicManager : MonoBehaviour {
	public AudioClip[] levelMusicChangeArray;
	private AudioSource _audio;

	void Awake ()
	{
		DontDestroyOnLoad(gameObject);
		_audio = GetComponent<AudioSource>()	;
	}

	void OnEnable ()
	{
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	void OnSceneLoaded (Scene scene, LoadSceneMode mode)
	{	
		AudioClip thisLevelMusic = levelMusicChangeArray[scene.buildIndex];

		if (thisLevelMusic) {
			_audio.clip = levelMusicChangeArray[scene.buildIndex];
			_audio.loop = true;
			_audio.Play();
		}

	}

	void OnDisable () 
	{
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}
	
}
