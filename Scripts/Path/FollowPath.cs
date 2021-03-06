﻿using UnityEngine;
using System.Collections;

public class FollowPath: MonoBehaviour {

	public GameObject target;
	public float ship_speed = 2f;
	Vector3 dir = new Vector3();

	void Start()
	{
		target = GameObject.FindGameObjectWithTag ("Path");
	}

	void Update () {
		dir = target.transform.position - transform.position;
		transform.Translate(dir.normalized * ship_speed * Time.deltaTime, Space.World);
		transform.LookAt (target.transform);
	}
}
