using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirAlTiempo : MonoBehaviour {

    public float tiempoVida; // Tiempo que se demora en destruir al objeto

    void Start()
    {
        Destroy(gameObject, tiempoVida); // Destruimos el objeto trascurido el tiempo
    }
}
