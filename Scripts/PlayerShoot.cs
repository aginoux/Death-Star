using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	[SerializeField]

	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			shoot ();
		}
	}

	void shoot()
	{
		//print ("Fire");
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out hit))
		{
			Debug.Log ("Hit:"+ hit.collider.name);
		}
	}
}
