using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemigo : MonoBehaviour {

    // Use this for initialization
    private Vector3 direccion;
    private float velocidad;
    public int tipoBala;
    private float velocidadX;
    private float velocidadY;
    public Camera refCamara;
    void Start () {
        velocidad = -0.5f;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (tipoBala == 0)
        {
            velocidad = -0.5f;
            direccion = new Vector3(transform.position.x, transform.position.y + velocidad, transform.position.z);
            transform.position = direccion;
            if (transform.position.y < (refCamara.transform.position.y + 25) * -1)
            {
                Destroy(this.gameObject);
            }
        }
        if (tipoBala == 1)
        {
            velocidad = 0.5f;
            direccion = new Vector3(transform.position.x, transform.position.y + velocidad, transform.position.z);
            transform.position = direccion;
            if (transform.position.y < (refCamara.transform.position.y + 25) * -1)
            {
                Destroy(this.gameObject);
            }
        }
        //Va en diagonal para la Izquierda
        if (tipoBala == 2)
        {
            velocidadY = -0.5f;
            velocidadX = -0.5f;

            direccion = new Vector3(transform.position.x + velocidadX, transform.position.y + velocidadY , transform.position.z);
            transform.position = direccion;
        }
        //Va en diagonal para la Derecha
        if (tipoBala == 3)
        {
            velocidadY = -0.5f;
            velocidadX = 0.5f;

            direccion = new Vector3(transform.position.x + velocidadX, transform.position.y + velocidadY , transform.position.z);
            transform.position = direccion;
        }
        //Va para la Izquierda
        if (tipoBala == 4)
        {
            velocidadX = -0.5f;
            direccion = new Vector3(transform.position.x + velocidadX, transform.position.y + velocidadY , transform.position.z);
            transform.position = direccion;
        }
        //Va para la Derecha
        if (tipoBala == 5)
        {
            velocidadX = 0.5f;
            direccion = new Vector3(transform.position.x + velocidadX, transform.position.y + velocidadY , transform.position.z);
            transform.position = direccion;
        }
    }
}
