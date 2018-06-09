using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaJugador : MonoBehaviour {

    // Use this for initialization
    private int _tipoBala;
    Vector3 direccion;
    public int tipoBala;
    private float randomItem;
    private float maxRandomItem = 5;
    public Camera refCamara;
    public GameObject refItemVida;
    public GameObject refItemPoder;
    private float velocidadY;
    private float velocidadX;
	void Start () {
        _tipoBala = tipoBala;
        velocidadY = 0;
        velocidadX = 0;
    }
	
	// Update is called once per frame
	void Update () {
        //FIJARSE COMO ESTA HECHO EL DISPARO EN EL FPS Y PASARLO
       
        if (_tipoBala == 1)
        {
            velocidadY = 0.5f;
            direccion = new Vector3(transform.position.x, transform.position.y+velocidadY, transform.position.z);
            transform.position = direccion;
            
        }
        if (_tipoBala == 2)
        {
            velocidadY = 0.5f;
            velocidadX = 0.5f;
           
            direccion = new Vector3(transform.position.x + velocidadX, transform.position.y + velocidadY + velocidadY, transform.position.z);
            transform.position = direccion;
        }
        if (_tipoBala == 3)
        {
            velocidadY = 0.5f;
            velocidadX = -0.5f;
            direccion = new Vector3(transform.position.x + velocidadX, transform.position.y + velocidadY + velocidadY, transform.position.z);
            transform.position = direccion;

            direccion = new Vector3(transform.position.x + velocidadX, transform.position.y + velocidadY + velocidadY, transform.position.z);
            transform.position = direccion;
        }
        if (transform.position.y > refCamara.transform.position.y + 25)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        //Debug.Log("ENTRE A TRIGGERED");
        if (collision.transform.gameObject.tag == "Enemigo")
        {
            Destroy(collision.transform.gameObject);
            randomItem = Random.Range(1, maxRandomItem);
            if ((int)randomItem == 1)
            {
                Instantiate(refItemVida, collision.transform.position, Quaternion.identity);
            }
            Destroy(this.gameObject);
        }
    }
}
