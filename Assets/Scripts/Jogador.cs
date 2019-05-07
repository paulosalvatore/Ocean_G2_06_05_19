using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour {

	Rigidbody2D rb;

	public float forcaPulo = 200f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		// Detecta se o botão esquerdo do mouse foi pressionado
		if (Input.GetMouseButtonDown(0))
		{
			Pular();
		}
	}

	private void Pular()
	{
		rb.velocity = Vector2.zero;
		rb.AddForce(Vector2.up * forcaPulo);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Inimigos"))
		{
			SceneManager.LoadScene(0);
		}
	}
}
