using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ControleTouch : MonoBehaviour {


	public float velocidade = 2.0f;

	void Update () {

		float mover_x = CrossPlatformInputManager.GetAxisRaw ("Horizonta") * velocidade * Time.deltaTime;
		float mover_y = CrossPlatformInputManager.GetAxisRaw ("Vertical") * velocidade * Time.deltaTime;

		
	}
}
