using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopViewHandler : MonoBehaviour {

	public Transform topView;
	public Transform BasementView;
	Camera mainCamera;
	public float speed;

	// Use this for initialization
	void Start () {
		mainCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetCamera() {
		mainCamera.transform.position = topView.position;
		mainCamera.transform.rotation = topView.rotation;
	}


	public void SetCameraBasement() {
		mainCamera.transform.position = BasementView.position;
		mainCamera.transform.rotation = BasementView.rotation;
	}

}
