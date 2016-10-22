using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dir = target.transform.position - transform.position;
		transform.Translate(dir.normalized * 2 * Time.deltaTime, Space.World);
	}
}
