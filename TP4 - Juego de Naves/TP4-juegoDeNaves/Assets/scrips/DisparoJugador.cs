using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour {

    // Use this for initialization
    //USAR LA MISMA LOGICA DE LAS BALAS PARA HACER LAS BOMBAS :3
    public Transform spawnBala;
    public GameObject Bala;
    public GameObject bombaJugador;
    private RaycastHit hit;
    public float rango;
    private int cantBombas;
	void Start () {
        cantBombas = 3;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(Bala, new Vector3(spawnBala.position.x,spawnBala.position.y+0.8f,spawnBala.position.z), Quaternion.identity);
            rango = 100;
        }
        if (Input.GetKeyDown(KeyCode.Space) && cantBombas>0)
        {
            Debug.Log("EXplotion");
            bombaJugador.SetActive(true);
            cantBombas--;
        }
        
	}
}
