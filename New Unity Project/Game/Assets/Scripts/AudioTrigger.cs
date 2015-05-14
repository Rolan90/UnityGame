﻿using UnityEngine;
using System.Collections;

 
public class AudioTrigger : MonoBehaviour {

	public AudioClip AudioVoice;
	public bool lanzar= true;

	public void OnTriggerEnter(Collider other){
		Debug.Log ("Ha entrado yeah suena voz mia suena!");

		playSonidoVoz();
	}
	public void playSonidoVoz(){
		GetComponent<AudioSource>().PlayOneShot(AudioVoice);

	}
}
