using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionController : MonoBehaviour {


	public Slider volumeSlider;
	public Slider difficultySlider;

	private MusicManager musicManager;
	private LevelManager levelManager;

	void Awake ()
	{
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}

	// Use this for initialization
	void Start () {
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (musicManager) {
			musicManager.ChangeVolume(volumeSlider.value);
		}

	}

	public void SaveAndExit () {
		PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
		PlayerPrefsManager.SetDifficulty(difficultySlider.value);
		levelManager.LoadScene("01a Start");
	}

	public void SetDefaults () {
		volumeSlider.value = .8f;
		difficultySlider.value = 2;
	}
}
