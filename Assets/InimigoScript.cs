using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoScript : MonoBehaviour {


	public int vidas;
	public GameObject peixePrefab;

	public Transform gerarPeixes;
	public float intervalo;


	IEnumerator Start () {

		Instantiate (peixePrefab, 
			gerarPeixes.position,
			gerarPeixes.rotation);
		yield return new WaitForSeconds(intervalo);
		StartCoroutine (Start ());
	}

	void OnCollisionEnter2D (Collision2D collision) {
		if (collision.gameObject.tag == "Projetil") {
			// Dano no inimigo
			vidas--;
			if (vidas <= 0) {
				// Destroi o inimigo
				Destroy (gameObject);
			}
			
		}

	}
}
