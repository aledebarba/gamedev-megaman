using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armaScript : MonoBehaviour {


	public GameObject projetilPrefab;
	public GameObject sensorRotacao;


	// Update is called once per frame
	void Update () {
		// Fire 1 (CTRL Esquerdo, Clique ou toque na tela)
		if (Input.GetButtonDown("Fire1")) {
			Instantiate(projetilPrefab,transform.position, transform.rotation);
			}

		if (Input.GetAxisRaw("Horizontal") > 0.0f){
			sensorRotacao.transform.eulerAngles = new Vector3 (0.0f,0.0f,0.0f);
		};
		if (Input.GetAxisRaw("Horizontal") < 0.0f){
			sensorRotacao.transform.eulerAngles = new Vector3 (0.0f, 180.0f, 0.0f);
		};
	}
}
