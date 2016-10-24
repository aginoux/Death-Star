using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Security.Cryptography;

public class Laser : MonoBehaviour {

	public float speed = 10f;
	public int waitBeforeDying = 4;

	void Start()
	{
		StartCoroutine (dead());
	}

	void Update () {
		transform.position += transform.forward * speed;
	}

	IEnumerator dead()
	{
		yield return new WaitForSeconds(waitBeforeDying);
		Destroy (gameObject);
	}

	void OnTriggerEnter()
	{
		Destroy (gameObject);
	}
}
