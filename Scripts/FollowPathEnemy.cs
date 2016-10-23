using UnityEngine;
using System.Collections;
using System.CodeDom.Compiler;

public class FollowPathEnemy: MonoBehaviour {

	public GameObject target;
	public float ship_speed = 2f;
	Vector3 dir = new Vector3();
	public float time_left=30f;
	public float time_before_destroy=5f;

	void Start()
	{
		target = GameObject.FindGameObjectWithTag ("PathEnemy");
	}

	void Update () {

		time_left -= Time.deltaTime;
		if (time_left < 0) {

			transform.Translate (Vector3.forward);
			transform.Rotate (-0.3f,0,0);

			time_before_destroy -= Time.deltaTime;
			if (time_before_destroy < 0) {
				Destroy (gameObject);
			}
		} 
		else {
			dir = target.transform.position - transform.position;
			transform.Translate(dir.normalized * ship_speed * Time.deltaTime, Space.World);
			transform.LookAt (target.transform);
		}
	}
}