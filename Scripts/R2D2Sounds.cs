using UnityEngine;
using System.Collections;

public class R2D2Sounds : MonoBehaviour {

	public AudioSource R2D2_sound_effect;

	//send message du path pour dire quelle musique play
	//Ou un audiosource par passage;

	void OnTriggerEnter(Collider collision_with)
	{
		if (collision_with.gameObject.tag == "Player")
		{
			//print ("R2D2");
			R2D2_sound_effect.Play ();
		}
	}
}
