using UnityEngine;
using System.Collections;

public class LaserAmbient : MonoBehaviour {

	public Transform laserAmbient;
	public float wait_before_shoot = 3f;
	float temporary_shoot;

	void Start(){
		temporary_shoot = wait_before_shoot;
	}

	void Update () {
		wait_before_shoot -= Time.deltaTime;
		if (wait_before_shoot < 0) {
		Vector3 start_pos = transform.position;
		Transform temp_laser = Instantiate(laserAmbient,start_pos,laserAmbient.rotation) as Transform;
		temp_laser.rotation = Quaternion.Euler (0, 0, 90);
		wait_before_shoot = temporary_shoot;
		}
	}
}
