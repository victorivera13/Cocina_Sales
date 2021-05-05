using Tobii.G2OM;
using UnityEngine;
using UnityEngine.UI;


    //Monobehaviour which implements the "IGazeFocusable" interface, meaning it will be called on when the object receives focus
    public class Tobii_prueba : MonoBehaviour, IGazeFocusable
    {
        public GameObject Display;
        public float tiempoMaximo;
        public Color HighlightColor = Color.red;
        public float AnimationTime = 0.1f;
        private Graphic _graphic;
        private Color _originalColor;
        private Color _targetColor;
        private bool flag=false;
        private float tiempo;

        //The method of the "IGazeFocusable" interface, which will be called when this object receives or loses focus
        public void GazeFocusChanged(bool hasFocus)
        {
            //If this object received focus, fade the object's color to highlight color
            if (hasFocus)
            {
                Display.SetActive(true);
                flag=true;
            }
            //If this object lost focus, fade the object's color to it's original color
            else
            {
                _targetColor = _originalColor;
            }
        }

        private void Start()
        {
            _graphic = GetComponent<Graphic>();
        }

        private void Update()
        {
            
            if(flag==true){

                tiempo += Time.deltaTime;
                if(tiempo>=tiempoMaximo){
                   Display.SetActive(false);
                   tiempo = 0f;
                   flag=false;
                }
            }
            
            
        }
    }
