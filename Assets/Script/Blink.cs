using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blink : MonoBehaviour {

	SpriteRenderer spriteRender;
	public float intervalo;

	// Use this for initialization
	IEnumerator Start () {

		GetComponent<SpriteRenderer> ().enabled = false;
		yield return new WaitForSeconds (intervalo);
		GetComponent<SpriteRenderer> ().enabled = true;
		yield return new WaitForSeconds (intervalo);

		StartCoroutine (Start ());
	}

	void UpDate(){
	
		// Pressionar enter
		if (Input.GetKeyDown (KeyCode.Return)) {
			SceneManager.LoadScene ("gamescene");
		}
	
	}


}
