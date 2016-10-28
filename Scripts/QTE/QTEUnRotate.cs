using UnityEngine;
using System.Collections;

public class QTEUnRotate : MonoBehaviour {

	public float speed_rotation = 30f;

	void OnTriggerStay(Collider collision_with)
	{
		//print ("QTE zone");
		if(collision_with.gameObject.tag == "MainCamera")
		{
			collision_with.gameObject.SendMessage ("unRotateThis" , speed_rotation);
		}
	}
}
