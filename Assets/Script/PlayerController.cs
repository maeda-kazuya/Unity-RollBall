using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 10;

	///*
	void FixedUpdate ()	{
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		Rigidbody rigidbody = GetComponent<Rigidbody> ();

		// xとzに10をかけて押す力をアップ
		rigidbody.AddForce(x * speed, 0, z * speed);
	}
	//*/

	/*
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	*/
}
