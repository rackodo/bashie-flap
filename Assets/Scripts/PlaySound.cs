using UnityEngine;
using UnityEngine.UI;

public class PlaySound : MonoBehaviour {
	AudioSource source;

	void Start() {
		source = GetComponent<AudioSource>();
	}

	public void Play() {
		Debug.Log(source);
		source.Play();
	}
}