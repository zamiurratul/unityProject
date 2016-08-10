using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	private Camera mainCamera;

	void Awake(){
		mainCamera = Camera.main;
	}

	public void ChangeColor () {
		mainCamera.backgroundColor = Random.ColorHSV ();
	}
}
