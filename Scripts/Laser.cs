using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Security.Cryptography;

public class Laser : MonoBehaviour {

	public float speed = 10f;
	public float waitBeforeDying = 4;

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
		//print ("destroy");
		Destroy (gameObject);
	}
	void OnTriggerExit()
	{
		//print ("destroy");
		Destroy (gameObject);
	}
	void OnTriggerStay()
	{
		//print ("destroy");
		Destroy (gameObject);
	}
}
