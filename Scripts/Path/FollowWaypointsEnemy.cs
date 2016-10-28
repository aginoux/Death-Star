using UnityEngine;
using System.Collections;
using System;

public class FollowWaypointsEnemy : MonoBehaviour {

	private Transform target;

	public float[] path_speed_array;
	public float distance_path_nextwaypoint = 0.2f;
	public bool finish = false;

	private Vector3 dir = new Vector3();
	private int waypoint_number = 0;

	void Start(){
		target = GetTransformChild.enemy_points [waypoint_number];
	}

	void Update () {
		if (!finish) 
		{
			dir = target.transform.position - transform.position;
			transform.Translate(dir.normalized * path_speed_array[waypoint_number] * Time.deltaTime, Space.World);
		}

		if (Vector3.Distance (transform.position, target.position) <= distance_path_nextwaypoint) 
		{
			//print (GetTransformChild.points.Length);
			//print (waypoint_number);
			if (waypoint_number == GetTransformChild.enemy_points.Length - 1) {
				finish = true;
			} 
			else {
				waypoint_number++;
				target = GetTransformChild.enemy_points [waypoint_number];
			}
		}
	}
}
