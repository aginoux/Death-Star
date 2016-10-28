using UnityEngine;
using System.Collections;

public class Moves : MonoBehaviour {

	public float speed_x_axis = 1f;
	public float speed_y_axis = 1f;

	//called by ontriggerstay QTE

	void moveXaxis() {
		float move_x = Input.GetAxis ("Horizontal");
		float posX = move_x * speed_x_axis;
		//print("posx" + posX);
		transform.position = new Vector3 (transform.position.x + posX, transform.position.y, transform.position.z);
	}

	void moveYaxis() {
		float move_y = Input.GetAxis ("Vertical");
		float posY = move_y * speed_y_axis;
		//print("posx" + posX);
		transform.position = new Vector3 (transform.position.x, transform.position.y  + posY, transform.position.z);
	}
}
