using UnityEngine;
using System.Collections;
using System.Security.Policy;

public class MoveLaserAmbient : MonoBehaviour {

	public float speed = 15;
	public float vec_x = 0;
	public float vec_y = 0;
	public float vec_z = 1;
	public float waitBeforeDying = 4;

	void Update () {
		transform.position += new Vector3(vec_x,vec_y,vec_z) * speed;
		transform.LookAt (-Vector3.right);
	}

	IEnumerator dead()
	{
		yield return new WaitForSeconds(waitBeforeDying);
		Destroy (gameObject);
	}
}
