﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour {

    // Use this for initialization
    //USAR LA MISMA LOGICA DE LAS BALAS PARA HACER LAS BOMBAS :3
    public Transform spawnBala;
    public GameObject TipoBala1;
    public GameObject TipoBala2;
    public GameObject TipoBala3;
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
            if (GameManager.tipoDisparo == 1)
            {
                //GameManager.tipoBala = 1;
                Instantiate(TipoBala1, new Vector3(spawnBala.position.x, spawnBala.position.y + 0.8f, spawnBala.position.z), Quaternion.identity);
                rango = 100;
            }
           if (GameManager.tipoDisparo == 2)
            {
                Instantiate(TipoBala1, new Vector3(spawnBala.position.x+0.2f, spawnBala.position.y + 0.8f, spawnBala.position.z), Quaternion.identity);
                Instantiate(TipoBala1, new Vector3(spawnBala.position.x -0.2f, spawnBala.position.y + 0.8f, spawnBala.position.z), Quaternion.identity);
            }
            if (GameManager.tipoDisparo == 3)
            {
                Debug.Log("ENTRE A 3");
                Instantiate(TipoBala1, new Vector3(spawnBala.position.x + 0.2f, spawnBala.position.y + 0.8f, spawnBala.position.z), Quaternion.identity);
                Instantiate(TipoBala1, new Vector3(spawnBala.position.x - 0.2f, spawnBala.position.y + 0.8f, spawnBala.position.z), Quaternion.identity);
                Instantiate(TipoBala2, new Vector3(spawnBala.position.x + 0.4f, spawnBala.position.y + 0.8f, spawnBala.position.z), Quaternion.identity);
                Instantiate(TipoBala3, new Vector3(spawnBala.position.x + -0.4f, spawnBala.position.y + 0.8f, spawnBala.position.z), Quaternion.identity);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && cantBombas>0)
        {
            Debug.Log("EXplotion");
            bombaJugador.SetActive(true);
            cantBombas--;
        }
        
	}
}
