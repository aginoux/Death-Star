using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	[SerializeField]
	private LayerMask mask;
	GameObject ui_canvas;
	public AudioSource audio_laser;
	public Transform prefab_laser;
	public float ajust_x_start_laser;
	public float ajust_y_start_laser;
	public float ajust_z_start_laser;
	public float depth_axis_z_mouse = 200;
	public float wait_between_switching_laser = 1;
	bool laser_right = false;
	bool play = true;

	public int add_x_points_to_score = 1;

	void Start(){
		ui_canvas = GameObject.FindGameObjectWithTag ("UI");
		StartCoroutine (Fire());
		//Cursor.visible = false;
	}

	void Update () {
		if (Input.GetButton ("Fire1")) {
			shoot ();
			audio_laser.enabled = true;
			audio_laser.loop = true;
		} 
		else 
		{
			audio_laser.enabled = false;
			audio_laser.loop = false;
		}
	}

	void shoot()
	{
		//print ("Fire");
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast (ray, out hit, Mathf.Infinity, mask)) {
			//Debug.Log ("Hit:"+ hit.collider.name);
			Vector3 target_1 = new Vector3 (hit.point.x + 2,hit.point.y,hit.point.z);
			Vector3 target_2 = new Vector3 (hit.point.x - 2,hit.point.y,hit.point.z);
			if (laser_right) 
			{
				animLaser (target_1, ajust_x_start_laser, ajust_y_start_laser, ajust_z_start_laser);
			} 
			else 
			{
				animLaser (target_2,-ajust_x_start_laser,ajust_y_start_laser,ajust_z_start_laser);
			}

			hit.collider.gameObject.SendMessage ("applyDamage", 0.5f);
			ui_canvas.SendMessage ("increaseScore", add_x_points_to_score);
		} 
		else
		{
			Vector3 target = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, depth_axis_z_mouse);
			Vector3 mouse_in_world = Camera.main.ScreenToWorldPoint (target);
			if (laser_right) 
			{
				animLaser (mouse_in_world,ajust_x_start_laser,ajust_y_start_laser,ajust_z_start_laser);
			} 
			else 
			{
				animLaser (mouse_in_world,-ajust_x_start_laser,ajust_y_start_laser,ajust_z_start_laser);
			}
		}
	}

	void animLaser(Vector3 target_this, float view_x, float view_y, float view_z)
	{
		Vector3 start_pos = new Vector3 (transform.position.x + view_x, transform.position.y + view_y, transform.position.z + view_z);
		Transform temp_laser = Instantiate(prefab_laser,start_pos,prefab_laser.rotation) as Transform;
		temp_laser.rotation = Quaternion.Euler (90, 0, 0);
		temp_laser.LookAt (target_this);
	}

	IEnumerator Fire()
	{
		while (play) 
		{
			laser_right = false;
			yield return new WaitForSeconds(wait_between_switching_laser);
			laser_right = true;
			yield return new WaitForSeconds(wait_between_switching_laser);
		}
	}
}
