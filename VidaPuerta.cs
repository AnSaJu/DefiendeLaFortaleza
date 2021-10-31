using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VidaPuerta : MonoBehaviour {

    public float vidaInicial = 100f;
    public Slider slider;
    public Image fillImagen;
    public Color fullVidaColor = Color.green;
    public Color ZeroVidaColor = Color.red;
    public Text gameOver;

   // public GameObject explosion;

    private float vidaActual;
    private FinJuego finJuego;

    public AudioSource sonidoGameOver;
    public GameObject sonidoFondo;

    private bool conVida = true;


    // Use this for initialization
    void Start ()
    {
        vidaActual = vidaInicial;
        ActualizarVida();

    }

    public void Damage(float dano)
    {
      
        vidaActual -= dano;
        ActualizarVida();
        if (vidaActual <= 0 && conVida)
        {
            gameOver.enabled = true;
            NivelSiguiente();
            sonidoGameOver.Play();
            sonidoFondo.SetActive(false);
            conVida = false;
            
            

        }
    }

    private void ActualizarVida()
    {
        slider.value = vidaActual;
        fillImagen.color = Color.Lerp(ZeroVidaColor, fullVidaColor, vidaActual /  vidaInicial);
    }

    private void NivelSiguiente()
    {
        Invoke("CargarNivel", 3f);
    }

    private void CargarNivel()
    {
        SceneManager.LoadScene(0);
        if (Puntaje.puntos >= Puntaje.mejorPuntaje)
        {
            Puntaje.mejorPuntaje = Puntaje.puntos;
        }
    }

}
