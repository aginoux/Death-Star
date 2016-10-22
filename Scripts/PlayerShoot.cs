using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	[SerializeField]
	private LayerMask mask;
	GameObject ui_canvas;

	public int add_x_points_to_score = 1;

	void Start(){
		ui_canvas = GameObject.FindGameObjectWithTag ("UI");
	}

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
			//Debug.Log ("Hit:"+ hit.collider.name);
			hit.collider.gameObject.SendMessage ("applyDamage", 0.5f);
			ui_canvas.SendMessage ("increaseScore", add_x_points_to_score);
		}
	}
}
