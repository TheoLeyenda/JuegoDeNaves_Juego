using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorEnemigos3_Nivel2 : MonoBehaviour
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
    // public Enemigo Enemigo11;

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
            if (Enemigo1 != null && Enemigo2 != null && Enemigo3 != null && Enemigo4 != null && Enemigo5 != null && Enemigo6 != null && Enemigo7 != null && Enemigo8 != null && Enemigo9 != null && Enemigo10 != null && Enemigo11 != null)
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
            }
            //Enemigo11.SetQuieto(false);
        }
        if (other.gameObject.tag == "Jugador")
        {
            activacion = 1;
        }
    }

}