using UnityEngine;
using System.Collections;

public class GetTransformChild : MonoBehaviour {

	public static Transform[] points;
	public static Transform[] enemy_points;

	void Awake()
	{
		if (gameObject.tag == "PlayerPoints") 
		{
			points = new Transform[transform.childCount];
			for (int i = 0; i < points.Length ; i++) 
			{
				points [i] = transform.GetChild (i);
			}
		}
		if (gameObject.tag == "EnemyPoints") 
		{
			enemy_points = new Transform[transform.childCount];
			for (int i = 0; i < enemy_points.Length ; i++) 
			{
				enemy_points [i] = transform.GetChild (i);
			}
		}
	}
}
