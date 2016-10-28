using UnityEngine;
using System.Collections;

public class QTERightLeft : MonoBehaviour {

	void OnTriggerStay(Collider collision_with)
	{
		//print ("QTE zone");
		if(collision_with.gameObject.tag == "Player")
		{
			collision_with.gameObject.SendMessage ("moveXaxis");
		}
	}
}
