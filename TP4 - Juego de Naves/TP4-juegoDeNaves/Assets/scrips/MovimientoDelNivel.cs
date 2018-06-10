using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDelNivel : MonoBehaviour {

    // Use this for initialization
    private Vector3 direccion;
    public float velScrolleo;
	void Start () {
        if (velScrolleo == 0 )
        {
            velScrolleo = -0.1f;
        }
	}
	
	// Update is called once per frame
	void Update () {
            direccion = new Vector3(transform.position.x, transform.position.y + velScrolleo, transform.position.z);
            transform.position = direccion;
	}
    public void SetVelScrolleo(float _velScrolleo)
    {
        velScrolleo = _velScrolleo;
    }
    public float GetVelScrolleo()
    {
        return velScrolleo;
    }
}
