using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	[SerializeField]
	private LayerMask mask;

	void Update () {
		if (Input.GetButton("Fire1")) {
			shoot ();
		}
	}

	void shoot()
	{
		//print ("Fire");
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray,out hit,Mathf.Infinity,mask))
		{
			Debug.Log ("Hit:"+ hit.collider.name);
			hit.collider.gameObject.SendMessage ("applyDamage", 0.5f);
		}
	}
}
