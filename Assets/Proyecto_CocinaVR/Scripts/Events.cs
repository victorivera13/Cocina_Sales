using UnityEngine;
using Valve.VR.InteractionSystem;

public class Events : MonoBehaviour
{
    public GameObject boton;
    private botonShowDetails showDetails;
    public void OnPress(Hand hand)
    {
        //Debug.Log("SteamVR Button pressed!");
        showDetails= FindObjectOfType<botonShowDetails>();
        //showDetails.Evento1();

    }

}
