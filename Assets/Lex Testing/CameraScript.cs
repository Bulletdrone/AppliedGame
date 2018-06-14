using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
	public Transform target;
	public float cameraSpeed = 15;
	float Offset = 72.5f;
	float yOffset = -60f;
	public bool smoothFollow = true;
	public bool freeLook = false;
	public float freeCamSpeed = 0.2f;

	void Update () {

		Vector3 pos = transform.position;
		if (Input.GetMouseButton(2))
		{
			pos.x -= Input.GetAxis("Mouse X") + Input.GetAxis("Mouse Y") * freeCamSpeed* Time.deltaTime;
			pos.z -= Input.GetAxis("Mouse Y") - Input.GetAxis("Mouse X") * freeCamSpeed* Time.deltaTime;
		}

		transform.position = pos;


		if (Input.GetKeyDown (KeyCode.C)) {
			smoothFollow = false; 
		} else {
			smoothFollow = true;
		}
		if (Input.GetKey (KeyCode.Mouse2)) {
			freeLook = true; 
		} else {
			freeLook = false;
		}

		if (target) {
			Vector3 newPos = transform.position;
			newPos.x = target.position.x - Offset;
			newPos.y = target.position.y - yOffset;
			newPos.z = target.position.z - Offset;


			if (!smoothFollow) {
				transform.position = newPos;
			} else if (!freeLook) {
				transform.position = Vector3.Lerp (transform.position, newPos, cameraSpeed * Time.deltaTime);
			} else if (freeLook) {
				;
			}
		}﻿
	}
}
