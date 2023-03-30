using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keluar : MonoBehaviour {

	public AudioSource ButtonSound;

	public void KeluarDariGame(){
		AudioSource buttonSound = ButtonSound.GetComponent<AudioSource> ();
		buttonSound.PlayOneShot (buttonSound.clip);
		Application.Quit ();
	}
}
