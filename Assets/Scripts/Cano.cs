﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cano : MonoBehaviour {

	public float velocidade = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector2.left * velocidade * Time.deltaTime);
	}
}
