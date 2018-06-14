using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombaJugador : MonoBehaviour {

    // Use this for initialization
    private float altura;
    private float anchura;
    private float profundidad;
    public Camera refCamera;
    private float timer;
    float velocidad;
	void Start () {
        //altura = Screen.height;
        //anchura = Screen.width;
        timer = 0;
        altura = refCamera.pixelHeight-350;
        anchura = refCamera.pixelWidth-450;
        profundidad = 0;
        transform.localScale = new Vector2(anchura, altura);
        transform.position = new Vector3(refCamera.transform.position.x,refCamera.transform.position.y,0);
	}
	
	// Update is called once per frame
	void Update () {
      timer = timer + Time.deltaTime;
        if (timer > 0.2f) // cuando el timer sea mayor que uno desactiva el objeto
        {
            timer = 0;
            gameObject.SetActive(false);
        }
	}
    private void OnTriggerStay(Collider collision)
    {
        //Debug.Log("ENTRE A TRIGGERED");
        if (collision.transform.gameObject.tag == "Enemigo")
        {
            Destroy(collision.transform.gameObject);
        }
    }
}
