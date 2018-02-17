using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilScript : MonoBehaviour {

	public float velocidade;

	// Use this for initialization
	void Start () {
		//Destroi objeto por tempo, caso não acerte em nada
		Destroy (gameObject, 3.0f);
	}


	void OnCollisionEnter2D (Collision2D collision) {
	// destroi tiro na colisão
		Destroy (gameObject);	
	}

	// destroi o SubInimigo detectando o trigger
	void OnTriggerEnter2D (Collider2D c){
		if (c.tag == "SubInimigo") {
			Destroy (c.gameObject);
		}
	}

	void Update () {
		// move o projetil
		transform.Translate(Vector2.right * velocidade * Time.deltaTime);
	}
}
