using UnityEngine;
using System.Collections;

public class Xwing : MonoBehaviour {

	public float time_before_destroy = 5f;

	void Update () {
		time_before_destroy -= Time.deltaTime;
		if (time_before_destroy < 0) {
			Destroy (gameObject);
		}
	}
}
