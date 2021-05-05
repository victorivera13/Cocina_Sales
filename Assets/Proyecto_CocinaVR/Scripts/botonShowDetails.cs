using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botonShowDetails : MonoBehaviour
{
    public GameObject plato;
    public float contador=0;
    public Text mensaje;
    public Text listaAlimentos;
    public Text mensajeFinal;
    public List<float> listaA;
    public Dictionary<string,float> listaD;
    string textoA;
    public float max=10;

    public void Update(){

        if(Input.GetKeyDown(KeyCode.E)){
            listaAlimentos.text="";
            contador =plato.GetComponentInParent<Calculate>().sumatotal;
            mensaje.text = "El total de azucar que consumes es de: " + contador +" cucharadas al día\n\n Alimentos seleccionados:";
            listaA = plato.GetComponentInParent<Calculate>().lista;
            listaD = plato.GetComponentInParent<Calculate>().listaD;
           
            foreach (KeyValuePair<string,float> item in listaD)
            {
                
                listaAlimentos.text += item.Key+" "+item.Value+" cucharadas\n";
            }
            CalcularSal(contador,max);
        }
    }


    void CalcularSal(float contador, float max){
        if(contador<max){
            mensajeFinal.text = "Buena eleccion de alimentos";
            
        }
        if(contador==max){
            mensajeFinal.text = "Estas al margen de tu limite diario";
        }
        if(contador>max){
            mensajeFinal.text = "Te has excedido de la cantidad diaria recomendada";
        }
    }
  
}
