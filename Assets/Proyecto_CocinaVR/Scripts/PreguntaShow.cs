using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreguntaShow : MonoBehaviour
{
    public GameObject Display;
    void Start()
    {
        Display.SetActive (false);
    }

    void OnTriggerStay(Collider col){
		
		if(col.tag=="PlayerInteractionZone"){
            
                if(Input.GetKeyDown(KeyCode.F)){
                    
                    Display.SetActive (true);
                }
            }
		
	}
	
}