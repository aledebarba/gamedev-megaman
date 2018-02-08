using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float velocidade;
	public float impulso;
	public Transform chaoVerificador;
	Animator animator;

	SpriteRenderer spriteRender;
	Rigidbody2D rb;
	bool estaNoChao;


	// Use this for initialization
	void Start () {
		spriteRender = GetComponent<SpriteRenderer> ();
		rb = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		// seta parametros de animação
		animator.SetFloat ("running", Mathf.Abs(Input.GetAxisRaw("Horizontal")));

		//mover
		float mover_x = Input.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;
		transform.Translate (mover_x, 0.0f, 0.0f);

		// verificar colisao com o Piso
		estaNoChao = Physics2D.Linecast(transform.position, 
										chaoVerificador.position, 
										1 << LayerMask.NameToLayer("Piso"));
		//pulo
		if (Input.GetButtonDown ("Jump") && (estaNoChao)) {
			rb.velocity = new Vector2 (0.0f, impulso);
		} 

		if (estaNoChao) {
			animator.SetFloat ("jumping", 0.0f);
		} 

		if (!estaNoChao) {
			animator.SetFloat ("jumping", 1.0f);
		} 

		// faz o flip do personagem
		if (mover_x > 0) {
			spriteRender.flipX = false;	
		} else if (mover_x < 0) {
			spriteRender.flipX = true;
		}


	}
}
