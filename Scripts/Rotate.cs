using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	float max_rotate = 90f;

	void rotateThis(float rotation)
	{
		//print ("tst" + transform.eulerAngles.z);
		if (transform.eulerAngles.z <= max_rotate) 
		{
			transform.Rotate (0, 0, rotation * Time.deltaTime);
		}
	}

	void unRotateThis(float rotation)
	{
		//print ("tst" + transform.eulerAngles.z);
		if (transform.eulerAngles.z >= 1) 
		{
			transform.Rotate (0, 0, -rotation * Time.deltaTime);
		}
	}

}
