using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MivimientoEnemigo : MonoBehaviour
{

    public float velocidad; // Velocidad del laser

    private Rigidbody rig; // Propiedades del cuerpo rigido

    private Animator animator;
    private Collider objCollider;
    
    private void Awake()
    {
        rig = GetComponent<Rigidbody>(); // Cargamos las propiedades del cuerpo rigido
        animator = GetComponent<Animator>();
        objCollider = GetComponent<Collider>();
    }

    void Start()
    {
        rig.velocity = -transform.forward * velocidad; // Movemos el laser por medio del cuerpo rigido y multiplicamos por la velocidad
    }

    private void OnTriggerEnter(Collider other) // Se activa cuando un triger entra en contacto
    {

        if (other.CompareTag("Espada"))
        {
            animator.SetBool("Vivo", false);
            rig.velocity = Vector3.zero;
            objCollider.enabled = false;
            
        }


    }
}
