using UnityEngine;
using System.Collections;

public class QTERotate : MonoBehaviour {

	public float speed_rotation = 30f;
	bool rotate = false;

	void Start()
	{
		rotate = false;
	}

	void OnTriggerStay(Collider collision_with)
	{
		//print ("QTE zone");
		if(collision_with.gameObject.tag == "MainCamera")
		{
			if (Input.GetKeyDown (KeyCode.Space)) 
			{
				rotate = true;
			}
			if (rotate) 
			{
				collision_with.gameObject.SendMessage ("rotateThis" , speed_rotation);
			}
		}
	}
}
