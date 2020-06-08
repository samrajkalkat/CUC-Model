using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {




	Camera mainCamera;
	private float speed = 5f;
	// Use this for initialization
	void Start () {
		mainCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	public void Up(){
		mainCamera.transform.Translate (Vector3.up * Time.deltaTime * 15);
	}

	public void Down(){
		mainCamera.transform.Translate (Vector3.down * Time.deltaTime * 15);
	}


}
