﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubInimigoScript : MonoBehaviour {

	public GameObject alvo;
	public float velocidade = 1.5f;
	float distancia;
	public SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
		alvo = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		// persegue o jogador
		transform.position = Vector2.Lerp (transform.position,
			alvo.transform.position, velocidade * Time.deltaTime);

		if (transform.position.x > alvo.transform.position.x) {
			sr.flipX = false;
		} else {
			sr.flipX = true;
		}

	}
}
