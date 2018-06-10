using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PasarNivel1 : MonoBehaviour {

    // Use this for initialization

    private float timer;
    private float tiempoPasarNivel1;
	void Start () {
        timer = 0;
        tiempoPasarNivel1 = 3;
	}
	
	// Update is called once per frame
	void Update () {
        timer = timer + Time.deltaTime;
        if (timer >= tiempoPasarNivel1)
        {
            SceneManager.LoadScene("Nivel1");
        }
	}
}
