using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

	public float fadeInTime = 2f;

	private Image _image;
	private Color currentColor = Color.black;

	void Awake () {
		_image = GetComponent<Image>();
	}

	void ImageFadeIn() {
		if (Time.timeSinceLevelLoad < fadeInTime) {
			float alphaChanged = Time.deltaTime / fadeInTime;
			currentColor.a -= alphaChanged;
			_image.color = currentColor;
		} else {
			gameObject.SetActive(false);
		}
	}

	// Update is called once per frame
	void Update () {
		ImageFadeIn();
	}
}
