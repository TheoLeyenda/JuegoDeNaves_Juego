using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PasarNivel2 : MonoBehaviour
{

    // Use this for initialization

    private float timer;
    private float tiempoPasarNivel2;
    void Start()
    {
        timer = 0;
        tiempoPasarNivel2 = 3;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= tiempoPasarNivel2)
        {
            SceneManager.LoadScene("Nivel2");
        }
    }
}
