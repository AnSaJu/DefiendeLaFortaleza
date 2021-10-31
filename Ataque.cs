using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour {

    public Rigidbody laser;
    public Transform puntoDeDisparo;
    public GameObject efecto;

    public float tiempoDisparo;
    public float velocidad;
    private float siguienteDisparo;

    public AudioSource sonidoAtaque;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
    
        if (Input.GetButton("Fire1") && Time.time > siguienteDisparo)
        {

            sonidoAtaque.Play();
           animator.SetBool("ataque", true);
            siguienteDisparo = Time.time + tiempoDisparo;
            Rigidbody disparo = Instantiate(laser, puntoDeDisparo.position, puntoDeDisparo.rotation) as Rigidbody;
            disparo.velocity = puntoDeDisparo.forward * velocidad;
            efecto.transform.position = puntoDeDisparo.position;
            Instantiate(efecto);

        }
        else
        {
            animator.SetBool("ataque", false);
        }
       
    }
        
}
