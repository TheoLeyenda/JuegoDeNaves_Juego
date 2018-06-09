using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemigo : MonoBehaviour {

    // Use this for initialization
    private Vector3 direccion;
    private float velocidad;
    public Camera refCamara;
    void Start () {
        velocidad = -0.5f; 
	}
	
	// Update is called once per frame
	void Update () {
        velocidad = -0.5f;
        direccion = new Vector3(transform.position.x, transform.position.y + velocidad, transform.position.z);
        transform.position = direccion;
        if (transform.position.y <  (refCamara.transform.position.y + 25)*-1)
        {
            Destroy(this.gameObject);
        }
    }
}
