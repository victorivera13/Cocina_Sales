using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Informacion : MonoBehaviour
{
    public GameObject Display;
    void Start()
    {
        Display.SetActive (false);
    }

    void OnTriggerEnter(Collider col){
		
		switch (col.gameObject.tag){
		case "PlayerInteractionZone":
            Display.SetActive (true);
			break;
		}
		
	}
	void OnTriggerExit(Collider col){
		
		switch (col.gameObject.tag){
		case "PlayerInteractionZone":
            Display.SetActive (false);
			break;
		}
	
	}
}
