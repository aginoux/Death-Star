using UnityEngine;
using System.Collections;

public class SoundEffects : MonoBehaviour {

	public AudioSource[] tie_effects;
	int chose_music;

	void Start () {
		chose_music = Random.Range (0, tie_effects.Length);
		print (chose_music);
		tie_effects [chose_music].Play();
	}
}
