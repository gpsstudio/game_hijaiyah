using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class feedpz : MonoBehaviour {
	public GameObject senyum;

	bool selesai = false;
	// Use this for initialization
	void Start () {

	}

	public void cek(){
		for (int i = 0; i < 20; i++) {
			if (transform.GetChild (i).GetComponent<drag> ().on_tempel) {
				selesai = true;
			} else {
				selesai = false;
				i = 20;
			}
		}
		if (selesai) {
			senyum.SetActive (true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (!selesai) {
			cek ();
		}

	}
}
