using UnityEngine;
using System.Collections;

public class Moves : MonoBehaviour {

	public float speed = 1f;

	void Update () {
		float move_x = Input.GetAxis ("Horizontal");
		float posX = move_x * speed;
		//print("posx" + posX);

		transform.position = new Vector3(transform.position.x + posX,transform.position.y,transform.position.z);

	}
}
