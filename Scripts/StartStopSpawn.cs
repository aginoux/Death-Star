using UnityEngine;
using System.Collections;

public class StartStopSpawn : MonoBehaviour {

	public GameObject spawnObject;

	void Start()
	{
		spawnObject = GameObject.FindGameObjectWithTag ("Spawn");
	}

	void OnTriggerEnter(Collider collision_with)
	{
		if (collision_with.gameObject.tag == "Player") 
		{
			spawnObject.SendMessage ("StartSpawn");
		}
	}
}
