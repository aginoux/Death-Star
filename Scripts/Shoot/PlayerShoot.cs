using UnityEngine;
using System.Collections;
using System.Threading;

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
	public float rate_fire = 1;
	float wait_between_switching_laser = 1;
	public float damage = 1f;
	bool laser_right_up = false;
	bool laser_right_down = false;
	bool laser_left_up = false;
	bool laser_left_down = false;
	bool play = true;

	public int add_x_points_to_score = 1;

	void Start(){
		wait_between_switching_laser = 0;
		ui_canvas = GameObject.FindGameObjectWithTag ("UI_score");
		StartCoroutine (Fire());
		//Cursor.visible = false;
	}

	void Update () {
		if (Input.GetButton ("Fire1")) {
			wait_between_switching_laser -= Time.deltaTime;
			if (wait_between_switching_laser < 0) {
				shoot ();
				audio_laser.Play();
			}
		} 
	}



	void shoot()
	{
		//print ("Fire");
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast (ray, out hit, Mathf.Infinity, mask)) {
			Debug.Log ("Hit:"+ hit.collider.name);
			Vector3 target_1 = new Vector3 (hit.point.x,hit.point.y,hit.point.z);
			Vector3 target_2 = new Vector3 (hit.point.x,hit.point.y,hit.point.z);
			print ("Fire");
			if (laser_right_up) 
			{
				animLaser (target_1, ajust_x_start_laser, ajust_y_start_laser, ajust_z_start_laser);
			} 
			else if(laser_right_down)
			{
				animLaser (target_2,ajust_x_start_laser, -ajust_y_start_laser,ajust_z_start_laser);
			}
			else if (laser_left_up) 
			{
				animLaser (target_1,-ajust_x_start_laser, ajust_y_start_laser, ajust_z_start_laser);
			} 
			else if (laser_left_down)
			{
				animLaser (target_2,-ajust_x_start_laser,-ajust_y_start_laser,ajust_z_start_laser);
			}

			hit.collider.gameObject.SendMessage ("applyDamage", damage);
			ui_canvas.SendMessage ("increaseScore", add_x_points_to_score);
		} 
		else
		{
			Vector3 target = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, depth_axis_z_mouse);
			Vector3 mouse_in_world = Camera.main.ScreenToWorldPoint (target);
			if (laser_right_up) 
			{
				animLaser (mouse_in_world, ajust_x_start_laser, ajust_y_start_laser, ajust_z_start_laser);
			} 
			else if (laser_right_down)
			{
				animLaser (mouse_in_world,ajust_x_start_laser, -ajust_y_start_laser,ajust_z_start_laser);
			}
			else if (laser_left_up) 
			{
				animLaser (mouse_in_world,-ajust_x_start_laser, ajust_y_start_laser, ajust_z_start_laser);
			} 
			else if(laser_left_down)
			{
				animLaser (mouse_in_world,-ajust_x_start_laser,-ajust_y_start_laser,ajust_z_start_laser);
			}
		}
		wait_between_switching_laser = rate_fire;
	}

	void animLaser(Vector3 target_this, float view_x, float view_y, float view_z)
	{
		Vector3 start_pos = new Vector3 (transform.position.x + view_x, transform.position.y + view_y, transform.position.z + view_z);
		Transform temp_laser = Instantiate(prefab_laser,start_pos,prefab_laser.rotation) as Transform;
		temp_laser.rotation = Quaternion.Euler (0, 0, 90);
		temp_laser.LookAt (target_this);
	}

	IEnumerator Fire()
	{
		while (play) 
		{
			laser_right_up = true;
			laser_right_down = false;
			laser_left_up = false;
			laser_left_down = false;
			yield return new WaitForSeconds(wait_between_switching_laser);
			laser_right_up = false;
			laser_right_down = false;
			laser_left_up = false;
			laser_left_down = true;
			yield return new WaitForSeconds(wait_between_switching_laser);
			laser_right_up = false;
			laser_right_down = true;
			laser_left_up = false;
			laser_left_down = false;
			yield return new WaitForSeconds(wait_between_switching_laser);
			laser_right_up = false;
			laser_right_down = false;
			laser_left_up = true;
			laser_left_down = false;
			yield return new WaitForSeconds(wait_between_switching_laser);
		}
	}
}
