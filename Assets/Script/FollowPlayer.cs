using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
	public Transform target;
	private Vector3 offset;


	void Update() {
		Debug.Log ("### Update FollowPlayer");

		GetComponent<Transform> ().position = target.position + offset;
		//GetComponent<Transform> ().position = target.position;

	}
	
	// Use this for initialization
//	/*
	void Start () {
		offset = GetComponent<Transform> ().position - target.position;
	}
//	*/

	/*
	// Update is called once per frame
	void Update () {
	
	}
	*/
}
