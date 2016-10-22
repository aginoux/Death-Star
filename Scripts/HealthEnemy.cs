using UnityEngine;
using System.Collections;

public class HealthEnemy : MonoBehaviour {

	public float current_health_enemy = 20f;

	void Update()
	{
		if (current_health_enemy <= 0) 
		{
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
}
