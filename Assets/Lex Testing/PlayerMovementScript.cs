using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovementScript : MonoBehaviour {
	float Speed = 3;
	public Transform target;
	Rigidbody rb;
	Transform aF;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponentInChildren <Rigidbody>();
		aF = transform.GetChild (0);
	}


	// Update is called once per frame
	void FixedUpdate () {

		Vector3 test = new Vector3 (Input.GetAxis ("Vertical") - Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical") + Input.GetAxis ("Horizontal")) * Speed;
		rb.velocity = (new Vector3 (test.z, rb.velocity.y, test.x));

		aF.localPosition = rb.velocity.normalized;

	}

	void OnTriggerEnter(Collider CEnter){
		//if (CEnter.gameObject.CompareTag ("...")) {
	
		//if (CEnter.gameObject.name == "...") {
	}
	void OnTriggerExit(Collider CExit){
		//if (CExit.gameObject.CompareTag("...")) {
	}
}