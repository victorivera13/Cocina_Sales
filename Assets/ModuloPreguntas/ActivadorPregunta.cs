using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorPregunta : MonoBehaviour {
	public GameObject Pregunta;
	// Use this for initialization
	void Start () {
		Pregunta.SetActive (false);
	}

	void OnTriggerEnter(Collider col){
		switch (col.gameObject.tag){
		case "PlayerInteractionZone":
			Pregunta.SetActive (true);
			break;
		}
	}
	/*void OnTriggerExit(Collider col){
		switch (col.gameObject.tag){
		case "PlayerInteractionZone":
			Pregunta.SetActive (false);
			break;
		}
	}*/
}
