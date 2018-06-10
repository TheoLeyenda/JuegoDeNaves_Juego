using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorEnemigos8_Nivel1 : MonoBehaviour
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
    public MovimientoDelNivel nivel1;
    private float auxVelScrolleo;
    private bool soloUnaVez;
    void Start()
    {
        activacion = 0;
        auxVelScrolleo = 0;
        soloUnaVez = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "CamaraColicionadora")
        {
            Debug.Log("Entre");
            if (Enemigo1 != null || Enemigo2 != null || Enemigo3 != null || Enemigo4 != null || Enemigo5 != null || Enemigo6 != null || Enemigo7 != null || Enemigo8 != null || Enemigo9 != null || Enemigo10 != null && Enemigo11 != null || Enemigo12 != null || Enemigo13 != null || Enemigo14 != null || Enemigo15 != null || Enemigo16 != null || Enemigo17 != null || Enemigo18 != null || Enemigo19 != null || Enemigo20 != null)
            {
                if (soloUnaVez)
                {
                    soloUnaVez = false;
                    auxVelScrolleo = nivel1.GetVelScrolleo();
                }
                Debug.Log("AuxVelScroleo" + auxVelScrolleo);
                nivel1.SetVelScrolleo(0);
            }
            if (Enemigo1 == null && Enemigo2 == null && Enemigo3 == null && Enemigo4 == null && Enemigo5 == null && Enemigo6 == null && Enemigo7 == null && Enemigo8 == null && Enemigo9 == null && Enemigo10 == null && Enemigo11 == null && Enemigo12 == null && Enemigo13 == null && Enemigo14 == null && Enemigo15 == null && Enemigo16 == null && Enemigo17 == null && Enemigo18 == null && Enemigo19 == null && Enemigo20 == null)
            {
                Debug.Log("Estoy Scroleando");
                nivel1.SetVelScrolleo(auxVelScrolleo);
            }
        }
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

        }
        if (other.gameObject.tag == "CamaraColicionadora")
        {
            activacion = 1;
        }
    }
}
