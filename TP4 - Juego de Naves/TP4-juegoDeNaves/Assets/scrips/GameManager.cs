using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static int tipoDisparo;
    public int puntos;
    public int tipoEnemigo;
    public Text textoPuntaje;
    private static GameManager instance;
    //public static int tipoBala;
    void Start()
    {
        //puntos = 0;
        tipoDisparo = 1;
        //tipoBala = 1;
        DontDestroyOnLoad(this);
        textoPuntaje.text = "" + puntos;
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
        //DESCOMENTAR EN CASO DE NO FUNCIONAR
        textoPuntaje.text = "" + puntos;
        instance = this;
    }
    public void SetPuntaje(int _puntaje)
    {
        puntos = _puntaje;
    }
    public int GetPuntaje()
    {
        return puntos;
    }
    public void SetTipoEnemigo(int _tipoEnemigo)
    {
        tipoEnemigo = _tipoEnemigo;
    }
}
