using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour {

    private float grados = 90f;
    public static float velosidadRotacion = 150f;
    public float radianes;
   // public float minX, maxX, minY, maxY;

    public float radioX;
    public float radioY;
	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update () {

        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimiento = -velosidadRotacion * movimientoHorizontal;

        grados += movimiento * Time.deltaTime;
        if(grados < 30)
        {
            grados = 30;
        }
        if(grados > 150)
        {
            grados = 150;
        }
        radianes = grados * Mathf.PI / 180; // comvertimos a radianes

        Vector3 posInCirculo = Vector3.zero;     
       /* posInCirculo.x = Mathf.Cos(radianes) * radioX;
        posInCirculo.y = Mathf.Sin(radianes) * radioY;*/

        posInCirculo.z = Mathf.Cos(radianes) * radioX;
        posInCirculo.x = Mathf.Sin(radianes) * radioY;

        transform.position = posInCirculo;
        transform.rotation = Quaternion.Euler(0f, grados, 0f);
        // transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY)); // permite restringir el movimiento del circulo
    }
}
