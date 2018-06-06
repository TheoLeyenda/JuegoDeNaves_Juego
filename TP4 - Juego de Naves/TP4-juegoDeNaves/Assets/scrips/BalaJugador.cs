using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaJugador : MonoBehaviour {
    private float origenX;
    private float origenZ;
    private float origenY;
    private float correrPosX;
    private float correrPosZ;
    private int tipoDisparo;
    private bool disparar;
    public GameObject refJugador;
    //public GameObject refBala;
    public Camera refCamara;
    public GameObject refBala;
    public float velocidad;
    private Vector3 direccion;
	// Use this for initialization
	void Start () {
        velocidad = 1f;
        correrPosX = 0;
        correrPosZ = 0;
        origenX = refJugador.transform.position.x;
        origenY = refJugador.transform.position.y; 
        origenZ = refJugador.transform.position.z;
        transform.Rotate(new Vector3(90, 0, 0));
        tipoDisparo = 1;
        disparar = false;
        //direccion = new Vector3(origenX, 0, origenZ);
    }
	
	// Update is called once per frame
	void Update () {
        //FIJARSE COMO ESTA HECHO EL DISPARO EN EL FPS Y PASARLO


        //Debug.Log("tipo:"+tipoDisparo);
        if (tipoDisparo == 1)
        {
            direccion = new Vector3(origenX, 0, origenZ);
            origenZ = origenZ + velocidad;
            transform.position = direccion;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            refBala = Instantiate(refBala, direccion, Quaternion.identity);
            disparar = true;
            //Debug.Log(refBala.GetComponent<BalaJugador>().getTipoDisparo());
        }
        if (transform.position.z > refCamara.transform.position.z + 25 && disparar)
        {
            Destroy(this.gameObject);
            disparar = false;
            //Debug.Log(transform.position.z);
        }
    }
    public void setTipoDisparo(int _tipoDisparo)
    {
        tipoDisparo = _tipoDisparo;
    }
    public int getTipoDisparo()
    {
        return tipoDisparo;
    }
}
