using UnityEngine;
using System.Collections;

public class Moves : MonoBehaviour {

	public float speed_x_axis;
	public float speed_y_axis;

	//called by ontriggerstay QTE

	void OnTriggerStay(Collider collision_with)
	{
		if(collision_with.gameObject.tag == "trench")
		{
			moveXaxis ();
			moveYaxis ();
		}
	}

	void moveXaxis() {
		float move_x = Input.GetAxis ("Horizontal");
		float posX = (move_x/2) * speed_x_axis;
		//print("posx" + posX);
		transform.position = new Vector3 (transform.position.x + posX, transform.position.y, transform.position.z);
	}

	void moveYaxis() {
		float move_y = Input.GetAxis ("Vertical");
		float posY = (move_y/2) * speed_y_axis;
		//print("posy" + posY);
		transform.position = new Vector3 (transform.position.x, transform.position.y  + posY, transform.position.z);
	}
}
