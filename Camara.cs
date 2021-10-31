using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {

    public Renderer puerta;
    public GameObject camara1;
    public GameObject camara2;
    private bool camara1Activa = true;
    private bool camara2Activa = false;
   
 

    // Use this for initialization
  /*  void Awake ()
    {
        puerta = GetComponent<Renderer>();
       
        puerta.enabled = true;
	}*/
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("q") && !camara1Activa)
        {
            puerta.enabled = true;
            camara1.SetActive(true);
            camara2Activa = false;
            camara2.SetActive(false);
            camara1Activa = true;
            MovimientoJugador.velosidadRotacion *= -1;
        }
        else
        {
            if (Input.GetKeyDown("q") && !camara2Activa)
            {
                
                camara2.SetActive(true);
                camara1Activa = false;
                camara1.SetActive(false);
                puerta.enabled = false;
                MovimientoJugador.velosidadRotacion *= -1 ;
            } 

        }


    }
}
