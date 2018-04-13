﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		this.transform.Translate(0.0f, 0.0f, 0.5f);
	}

	void OnCollisionEnter(Collision collision){
		Destroy (collision.collider.gameObject);
	}

}
