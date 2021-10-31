using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestuirAlContacto : MonoBehaviour {


    public GameObject oSonidoDestruir;

   

    private void OnTriggerEnter(Collider other) // Se activa cuando un triger entra en contacto
    {
        
        if (other.CompareTag("Enemigo"))
        {
            Instantiate(oSonidoDestruir);
            Destroy(other.gameObject, 1f);// Destrulle el objeto en contacto
            Destroy(gameObject);// Destrulle este objeto

        }
       

    }
}
