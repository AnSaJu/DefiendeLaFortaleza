using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour {

    public static float puntos;
    public static float mejorPuntaje;
    public Text puntosTxt;

    private float siguientePunto;
    private float tiempoPunto = 1f;

    // Use this for initialization
    void Start()
    {
        puntos = 0f;
        UpdateScore();

    }

    private void Update()
    {
        GanarPuntos();       
    }

    // Update is called once per frame
    public void GanarPuntos()
    {
        
        if(Time.time > siguientePunto)
        {
            siguientePunto = Time.time + tiempoPunto;
            puntos += 10; 
        }
        UpdateScore();
    }

    private void UpdateScore()
    {
        puntosTxt.text = "Score: " + puntos;
    }
}
