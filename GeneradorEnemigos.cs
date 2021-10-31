using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{

    public GameObject meteorito;    
    public Vector3 posicionMeteorito;
    public int cantidadMeteoritos;
    public float tiempoEspera;
    public float esperaInicial;
    public float esperaHorda;


    private float grados;
    private float radianes;
    public float radioX;
    public float radioY;


    void Start()
    {
        StartCoroutine(GenerarMeteorito());

    }

    private IEnumerator GenerarMeteorito()
    {
        yield return new WaitForSeconds(esperaInicial);
        while (true)
        {
            for (int i = 0; i < cantidadMeteoritos; i++)
            {
                Transform posicion = MovimientoEnemigo();//new Vector3(Random.Range(-posicionMeteorito.x, posicionMeteorito.x), posicionMeteorito.y, posicionMeteorito.z);
                Instantiate(meteorito, posicion.position , posicion.rotation);               
                yield return new WaitForSeconds(tiempoEspera);
            }
            yield return new WaitForSeconds(esperaHorda);
        }
    }


    Transform MovimientoEnemigo()
    {
        grados = Random.Range(30, 150);

        radianes = grados * Mathf.PI / 180; // comvertimos a radianes

        Vector3 posInCirculo = Vector3.zero;
        posInCirculo.z = Mathf.Cos(radianes) * radioX;
        posInCirculo.x = Mathf.Sin(radianes) * radioY;

        transform.position = posInCirculo;
        transform.rotation = Quaternion.Euler(0f, grados, 0f);
      

        return transform;
         
    }
        



}
