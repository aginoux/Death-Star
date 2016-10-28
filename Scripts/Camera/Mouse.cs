using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {

	public float correction_x = -4f;
	public float correction_y = -5f;

	void Start()
	{
		Cursor.visible = false;
	}

	void Update () {
		transform.position = new Vector3(Input.mousePosition.x + correction_x, Input.mousePosition.y + correction_y, Input.mousePosition.z);
	}
}
