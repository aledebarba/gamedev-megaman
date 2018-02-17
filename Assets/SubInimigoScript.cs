using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubInimigoScript : MonoBehaviour {

	public GameObject alvo;
	public float velocidade = 1.5f;

	// Use this for initialization
	void Start () {
		alvo = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		// persegue o jogador
		transform.position = Vector2.Lerp (transform.position,
			alvo.transform.position, velocidade * Time.deltaTime);
		
	}
}
