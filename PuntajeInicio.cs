using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntajeInicio : MonoBehaviour {

    public Text puntaje;
    public Text textmejorPuntaje;


	// Use this for initialization
	void Start ()
    {
        puntaje.text = "" + Puntaje.puntos;

        textmejorPuntaje.text = "" + Puntaje.mejorPuntaje;
        
	}
	

}
