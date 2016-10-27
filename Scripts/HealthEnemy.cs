using UnityEngine;
using System.Collections;

public class HealthEnemy : MonoBehaviour {

	public float current_health_enemy = 20f;
	public int add_x_points_to_score = 100;
	GameObject ui_canvas;

	void Start(){
		ui_canvas = GameObject.FindGameObjectWithTag ("UI");
	}

	void Update()
	{
		if (current_health_enemy <= 0) 
		{
			ui_canvas.SendMessage ("increaseScore", add_x_points_to_score);
			Destroy (transform.parent.gameObject);
		}
	}

	void applyDamage(float damage)
	{
		if (current_health_enemy > 0) 
		{
			current_health_enemy -= damage;
		}
	}

	/*
	void OnTriggerEnter(Collider collision_with)
	{
		print ("destroy");
		if(collision_with.gameObject.tag == "Laser")
		{
			print ("destroy");
			Destroy (collision_with.gameObject);
		}
	}*/
}
