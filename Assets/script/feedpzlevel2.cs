﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feedpzlevel2 : MonoBehaviour {
	public GameObject senyum;
	bool selesai = false;
	// Use this for initialization
	void Start () {
		
	}

	public void cek(){
		for (int i = 0; i < 4; i++) {
			if (transform.GetChild (i).GetComponent<drag> ().on_tempel) {
				selesai = true;
			} else {
				selesai = false;
				i = 4;
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
