using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	Transform[] spawns_places;
	public GameObject enemy_prefab;
	public float wait_time_between_spawns = 3;
	public bool play = true;

	void Awake()
	{
		spawns_places = new Transform[transform.childCount];
		for (int i = 0; i < spawns_places.Length ; i++) 
		{
			spawns_places [i] = transform.GetChild (i);
		}
	}

	void StartSpawn()
	{
		GameObject path_enemy = GameObject.FindGameObjectWithTag ("PathEnemy");
		path_enemy.GetComponent<FollowWaypointsEnemy> ().enabled = true;
		StartCoroutine (Fire());
	}

	public void enemySpawn()
	{
		Instantiate (enemy_prefab,spawns_places [Random.Range(0,spawns_places.Length)].transform.position,Quaternion.identity);
	}
		
	IEnumerator Fire()
	{
		while (play) 
		{
			yield return new WaitForSeconds(wait_time_between_spawns);
			enemySpawn ();
		}
	}

}
