using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class huruf : MonoBehaviour {
	public GameObject hijaiyah_benar, hijaiyah_salah;

	// Use this for initialization
	void Start () {
		
	}
	public void jawaban(bool huruf){
		if (huruf) {
			hijaiyah_benar.SetActive (false);
			hijaiyah_salah.SetActive (true);
		}
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
