﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour {
	public Transform car;
	void LateUpdate(){
		Vector3 newPos = car.position;
		newPos.y = transform.position.y;
		transform.position = newPos;
		transform.rotation = Quaternion.Euler (90f, car.eulerAngles.y, 0f);
	}
}