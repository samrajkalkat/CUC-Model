using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFire : MonoBehaviour {

	public GameObject fire;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ToggleFire() {
		if (fire.activeSelf == false) {
			fire.SetActive (true);
		} else {
			fire.SetActive (false);
		}
	}
}

