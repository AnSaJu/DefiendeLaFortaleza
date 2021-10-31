using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPuerta : MonoBehaviour {

    private VidaPuerta vidaPuerta;
    public float damage = 10f;
    private float rotacion = 90f;
    public float rotacionPuerta = 10f;

    public AudioSource sonidoPuerta;

    private void Awake()
    {
        vidaPuerta = GetComponent<VidaPuerta>();
    }

    void FixedUpdate()
    {
         
    }

    private void OnTriggerEnter(Collider other) // Se activa cuando un triger entra en contacto
    {
        sonidoPuerta.Play();
        Destroy(other.gameObject);// Destrulle el objeto en contacto
        //transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
        rotacion += rotacionPuerta;
        vidaPuerta.Damage(damage);
        transform.rotation = Quaternion.Euler(rotacion, 90f, 360f);
        //transform.rotation = new Quaternion(rotacionX, transform.rotation.y, transform.rotation.z, transform.rotation.w);
        
    }
}
