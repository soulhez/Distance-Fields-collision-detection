﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour {
	// Update is called once per frame
	public float radius = 0.5f;
	private IObstacle _collider;
	void Start()
	{
		_collider = GetComponent<CircleObstacle> ();
	}
	void Update () {
		
		float h = Input.GetAxis ("Horizontal");  
		float v = Input.GetAxis ("Vertical");  

		Move((Vector3.right * h*4f + Vector3.up * v*4f) * Time.deltaTime);

	}

	public void Move(Vector2 dir)
	{
		DistanceFields.Instance.selfObs = _collider;
		transform.position = DistanceFields.Instance.Move (transform.position,radius,dir);
		DistanceFields.Instance.selfObs = null;
	}
}
