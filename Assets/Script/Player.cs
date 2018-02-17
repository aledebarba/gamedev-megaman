using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float velocidade;
	public float impulso;
	bool estaNoChao;

	public Transform chaoVerificador;
	Animator animator;
	SpriteRenderer spriteRender;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
		spriteRender = GetComponent<SpriteRenderer> ();
		rb = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
	}
		
	// Update is called once per frame
	void Update () {
		// Animacores
		// seta parametros de animação
		animator.SetFloat ("running", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
		animator.SetBool("bfire", Input.GetButton("Fire1"));

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

		// faz o flip de acordo com o valor de move_x 
		if (mover_x != 0) {
			spriteRender.flipX = mover_x < 0;
		}
	}
}
