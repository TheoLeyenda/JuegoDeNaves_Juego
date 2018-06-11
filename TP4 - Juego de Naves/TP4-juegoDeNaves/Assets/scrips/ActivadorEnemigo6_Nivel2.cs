using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorEnemigo6_Nivel2 : MonoBehaviour
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
    public Enemigo Enemigo28;
    public Enemigo Enemigo29;
    public Enemigo Enemigo30;
    public Enemigo Enemigo31;
    public Enemigo Enemigo32;
    public Enemigo Enemigo33;
    public Enemigo Enemigo34;
    public Enemigo Enemigo35;
    public Enemigo Enemigo36;
    public Enemigo Enemigo37;
    public Enemigo Enemigo38;
    public Enemigo Enemigo39;
    public Enemigo Enemigo40;
    public Enemigo Enemigo41;
    public Enemigo Enemigo42;
    public Enemigo Enemigo43;
    public Enemigo Enemigo44;
    public Enemigo Enemigo45;
    public Enemigo Enemigo46;
    public Enemigo Enemigo47;
    public Enemigo Enemigo48;
    public Enemigo Enemigo49;
    public Enemigo Enemigo50;
    public Enemigo Enemigo51;
    public Enemigo Enemigo52;
    public Enemigo Enemigo53;
    public Enemigo Enemigo54;
    public Enemigo Enemigo55;
    public Enemigo Enemigo56;
    public Enemigo Enemigo57;
    public Enemigo Enemigo58;
    public Enemigo Enemigo59;
    public Enemigo Enemigo60;
    public Enemigo Enemigo61;
    public Enemigo Enemigo62;
    public Enemigo Enemigo63;
    public Enemigo Enemigo64;
    public Enemigo Enemigo65;
    public Enemigo Enemigo66;
    public Enemigo Enemigo67;
    public Enemigo Enemigo68;
    public Enemigo Enemigo69;
    public Enemigo Enemigo70;
    public Enemigo Enemigo71;
    public Enemigo Enemigo72;

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
            Enemigo28.SetQuieto(false);
            Enemigo29.SetQuieto(false);
            Enemigo30.SetQuieto(false);
            Enemigo31.SetQuieto(false);
            Enemigo32.SetQuieto(false);
            Enemigo33.SetQuieto(false);
            Enemigo34.SetQuieto(false);
            Enemigo35.SetQuieto(false);
            Enemigo36.SetQuieto(false);
            Enemigo37.SetQuieto(false);
            Enemigo38.SetQuieto(false);
            Enemigo39.SetQuieto(false);
            Enemigo40.SetQuieto(false);
            Enemigo41.SetQuieto(false);
            Enemigo42.SetQuieto(false);
            Enemigo43.SetQuieto(false);
            Enemigo44.SetQuieto(false);
            Enemigo45.SetQuieto(false);
            Enemigo46.SetQuieto(false);
            Enemigo47.SetQuieto(false);
            Enemigo48.SetQuieto(false);
            Enemigo49.SetQuieto(false);
            Enemigo50.SetQuieto(false);
            Enemigo51.SetQuieto(false);
            Enemigo52.SetQuieto(false);
            Enemigo53.SetQuieto(false);
            Enemigo54.SetQuieto(false);
            Enemigo55.SetQuieto(false);
            Enemigo56.SetQuieto(false);
            Enemigo57.SetQuieto(false);
            Enemigo58.SetQuieto(false);
            Enemigo59.SetQuieto(false);
            Enemigo60.SetQuieto(false);
            Enemigo61.SetQuieto(false);
            Enemigo62.SetQuieto(false);
            Enemigo63.SetQuieto(false);
            Enemigo64.SetQuieto(false);
            Enemigo65.SetQuieto(false);
            Enemigo66.SetQuieto(false);
            Enemigo67.SetQuieto(false);
            Enemigo68.SetQuieto(false);
            Enemigo69.SetQuieto(false);
            Enemigo70.SetQuieto(false);
            Enemigo71.SetQuieto(false);
            Enemigo72.SetQuieto(false);
        }
        if (other.gameObject.tag == "Jugador")
        {
            activacion = 1;
        }
    }

}
