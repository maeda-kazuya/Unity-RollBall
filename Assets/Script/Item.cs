using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	void OnTriggerEnter(Collider hit) {
		Debug.Log ("### Collision!!");
		
		//Destroy (gameObject);
		//GameObject.Destroy();
		Rigidbody rigidbody = GetComponent<Rigidbody> ();
		GameObject.Destroy (rigidbody);
		if (hit.CompareTag ("Player")) {
			Destroy (gameObject);
		}
	}


	/*
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	*/
}
