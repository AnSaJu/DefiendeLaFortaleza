using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinJuego : MonoBehaviour {

    public float retraso;

    public void NivelSiguiente()
    {
        Invoke("CargarNivel", 2f);
    }

    private void CargarNivel()
    {
        SceneManager.LoadScene(0);
    }
}
