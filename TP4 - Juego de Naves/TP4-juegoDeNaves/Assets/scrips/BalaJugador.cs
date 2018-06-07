using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaJugador : MonoBehaviour {

    // Use this for initialization
    private int _tipoDisparo;
    Vector3 direccion;
    public Camera refCamara;
    private float velocidad;
	void Start () {
        _tipoDisparo = GameManager.tipoDisparo;
        velocidad = 0;
    }
	
	// Update is called once per frame
	void Update () {
        //FIJARSE COMO ESTA HECHO EL DISPARO EN EL FPS Y PASARLO
       
        if (_tipoDisparo == 1)
        {
            velocidad = 0.5f;
            direccion = new Vector3(transform.position.x, transform.position.y+velocidad, transform.position.z);
            transform.position = direccion;
            
        }
        if (transform.position.y > refCamara.transform.position.y + 25)
        {
            Destroy(this.gameObject);
        }
    }
}
