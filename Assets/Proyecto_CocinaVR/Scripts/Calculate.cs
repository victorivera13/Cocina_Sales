using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculate : MonoBehaviour
{
    public List<float> lista = new List<float>();
    public Dictionary<string,float> listaD = new Dictionary<string,float>();
    public float sumatotal=0;

    void OnTriggerEnter(Collider other) {
        if(other.tag=="Objeto"){

            listaD.Add(other.GetComponentInParent<Datos>().nombre,other.GetComponentInParent<Datos>().azucar); 
            sumatotal +=other.GetComponentInParent<Datos>().azucar;
            
            //Debug.Log(other.GetComponentInParent<Datos>().nombre + " contiene " + other.GetComponentInParent<Datos>().sal +" de sal");
        }
        
    }
    void OnTriggerExit(Collider other) {
        if(other.tag=="Objeto"){
            listaD.Remove(other.GetComponentInParent<Datos>().nombre);
            sumatotal -=other.GetComponentInParent<Datos>().azucar;
            //Debug.Log(other.GetComponentInParent<Datos>().nombre + " salio ");
        }
        
    }

}