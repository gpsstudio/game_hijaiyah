﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlpz : MonoBehaviour {
	public GameObject parent;
	// Use this for initialization
	void Start () {
		
	}

	int urutan = 0;

	void aktif(int a){
		urutan += a;
		if (urutan < 0) {
			urutan = parent.transform.childCount - 1;
		} else if (urutan > parent.transform.childCount -1) {
			urutan = 0;
		}
		for (int i = 0; i < parent.transform.childCount; i++) {
			parent.transform.GetChild (i).gameObject.SetActive (false);
		}
		parent.transform.GetChild (urutan).gameObject.SetActive (true);
	}

	void OnMouseUp(){
		if (gameObject.name == "next1") {
			aktif (1);
		} else {
			aktif (-1);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
