﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextFase1 : MonoBehaviour
{
    public GameObject Scene;
        void OnTriggerStay(Collider col){
            if(col.tag=="GameController"){
                if(Input.GetKeyDown(KeyCode.F)){
                    
                    SceneManager.LoadScene("Diagnostico");
                }
            }
        }

}
