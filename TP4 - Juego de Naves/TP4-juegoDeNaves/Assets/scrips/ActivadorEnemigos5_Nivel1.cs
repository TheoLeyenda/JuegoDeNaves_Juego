using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorEnemigos5_Nivel1 : MonoBehaviour
{

    // Use this for initialization
    private int activacion;
    public Enemigo Enemigo1;
    public Enemigo Enemigo2;
    public Enemigo Enemigo3;
    public Enemigo Enemigo4;
    public Enemigo Enemigo5;
    public Enemigo Enemigo6;
    public Enemigo Enemigo7;
    public Enemigo Enemigo8;
    public Enemigo Enemigo9;
    public Enemigo Enemigo10;
    public Enemigo Enemigo11;
    public Enemigo Enemigo12;
    public Enemigo Enemigo13;
    public Enemigo Enemigo14;
    public Enemigo Enemigo15;
    public Enemigo Enemigo16;
    public Enemigo Enemigo17;
    public Enemigo Enemigo18;
    public Enemigo Enemigo19;
    public Enemigo Enemigo20;
    public Enemigo Enemigo21;
    public Enemigo Enemigo22;
    public Enemigo Enemigo23;
    public Enemigo Enemigo24;
    public Enemigo Enemigo25;
    public Enemigo Enemigo26;
    public Enemigo Enemigo27;
    void Start()
    {
        activacion = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (activacion >= 1)
        {
           
            Enemigo1.SetQuieto(false);
            Enemigo2.SetQuieto(false);
            Enemigo3.SetQuieto(false);
            Enemigo4.SetQuieto(false);
            Enemigo5.SetQuieto(false);
            Enemigo6.SetQuieto(false);
            Enemigo7.SetQuieto(false);
            Enemigo8.SetQuieto(false);
            Enemigo9.SetQuieto(false);
            Enemigo10.SetQuieto(false);
            Enemigo11.SetQuieto(false);
            Enemigo12.SetQuieto(false);
            Enemigo13.SetQuieto(false);
            Enemigo14.SetQuieto(false);
            Enemigo15.SetQuieto(false);
            Enemigo16.SetQuieto(false);
            Enemigo17.SetQuieto(false);
            Enemigo18.SetQuieto(false);
            Enemigo19.SetQuieto(false);
            Enemigo20.SetQuieto(false);
            Enemigo21.SetQuieto(false);
            Enemigo22.SetQuieto(false);
            Enemigo23.SetQuieto(false);
            Enemigo24.SetQuieto(false);
            Enemigo25.SetQuieto(false);
            Enemigo26.SetQuieto(false);
            Enemigo27.SetQuieto(false);
        }
        if (other.gameObject.tag == "Jugador")
        {
            activacion = 1;
        }
    }
}
