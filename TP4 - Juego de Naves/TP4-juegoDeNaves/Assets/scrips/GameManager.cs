using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static int tipoDisparo;
    public int puntos;
    public Text textoPuntaje;
    private static GameManager instance;
    //public static int tipoBala;
    void Start()
    {
        puntos = 0;
        tipoDisparo = 1;
        //tipoBala = 1;
    }
    void Update()
    {
        textoPuntaje.text = "" + puntos;
    }
    public static GameManager Get()
    {
        return instance;
    }

    private void Awake()
    {
        puntos = 0;
        instance = this;
    }
    public void setPuntaje(int _puntaje)
    {
        puntos = _puntaje;
    }
    public int getPuntaje()
    {
        return puntos;
    }
}
