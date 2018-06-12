using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemigo : MonoBehaviour {

    // Use this for initialization
    private Vector3 direccion;
    private float velocidad;
    public int tipoBala;
    private bool soloUnaVez;
    private float velocidadX;
    private float velocidadY;
    public Camera refCamara;
    private float limiteReboteBala;
    private bool izquierda;
    private bool derehca;
    private float dileyDeColicion;
    void Start () {
        velocidad = -0.5f;
        soloUnaVez = true;
        limiteReboteBala = 3;
        dileyDeColicion = 3;
	}
	
	// Update is called once per frame
	void Update () {
        if (refCamara.WorldToScreenPoint(transform.position).y < -refCamara.pixelHeight-20  || refCamara.WorldToScreenPoint(transform.position).y > refCamara.pixelHeight+1000 || refCamara.WorldToScreenPoint(transform.position).x > refCamara.pixelWidth+20 || refCamara.WorldToScreenPoint(transform.position).x < -refCamara.pixelWidth-20)
        {
            Destroy(this.gameObject);
        }
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
        if (tipoBala == 6)
        {
            velocidadY = 0.5f;
            direccion = new Vector3(transform.position.x, transform.position.y + velocidadY, transform.position.z);
            transform.position = direccion;
        }
        if (tipoBala == 7)
        {
            if (soloUnaVez)
            {
                soloUnaVez = false;
                velocidadX = 0.7f;
                velocidadY = -0.5f;
                dileyDeColicion = 0;
                izquierda = true;
            }
            if (dileyDeColicion > 0)
            {
                dileyDeColicion = dileyDeColicion - Time.deltaTime;

            }
            if (dileyDeColicion <= 0)
            {
                dileyDeColicion = 3;
                if (derehca)
                {
                    derehca = false;
                    izquierda = true;
                }
                else
                {
                    derehca = true;
                    izquierda = false;
                }
            }
            if (transform.position.x > limiteReboteBala && izquierda)
            {
                velocidadX = -0.5f;
            }
            if (transform.position.x < -limiteReboteBala && derehca)
            {
                velocidadX = 0.5f;
            }
            direccion = new Vector3(transform.position.x + velocidadX, transform.position.y + velocidadY, transform.position.z);
            transform.position = direccion;
        }
        if (tipoBala == 8)
        {
            if (soloUnaVez)
            {
                soloUnaVez = false;
                velocidadX = 0.7f;
                velocidadY = -0.5f;
                dileyDeColicion = 0;
                derehca = true;
            }
            if (dileyDeColicion > 0)
            {
                dileyDeColicion = dileyDeColicion - Time.deltaTime;
                
            }
            if (dileyDeColicion <= 0)
            {
                dileyDeColicion = 3;
                if (derehca)
                {
                    derehca = false;
                    izquierda = true;
                }
                else
                {
                    derehca = true;
                    izquierda = false;
                }
            }
            if (transform.position.x > refCamara.pixelWidth && izquierda)
            {
                velocidadX = -0.5f;
            }
            if (transform.position.x < -refCamara.pixelWidth && derehca)
            {
                velocidadX = 0.5f;
            }
            direccion = new Vector3(transform.position.x+velocidadX, transform.position.y + velocidadY, transform.position.z);
            transform.position = direccion;
        }
    }
}
