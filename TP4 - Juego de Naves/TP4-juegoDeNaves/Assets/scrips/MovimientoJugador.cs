using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour {

    // Use this for initialization
    public Camera refCamara;
    public GameObject refJugador;
    private Vector3 direcion;
    public float velocidadJugador;
    private float x;
    private float y;
	void Start () {
        x = refJugador.transform.position.x;
        y = refJugador.transform.position.z;
        //transform.Rotate(new Vector3(90, 0, 0));
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            y = y + velocidadJugador;
            direcion = new Vector3(x, y, 0);
            refJugador.transform.position = direcion;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x = x - velocidadJugador;
            direcion = new Vector3(x, y, 0);
            refJugador.transform.position = direcion;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            x = x + velocidadJugador;
            direcion = new Vector3(x, y, 0);
            refJugador.transform.position = direcion;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            y = y - velocidadJugador;
            direcion = new Vector3(x, y, 0);
            refJugador.transform.position = direcion;
        }
       // direcion = new Vector3(x, 0, z);
        //refJugador.transform.position = direcion;
	}
}
