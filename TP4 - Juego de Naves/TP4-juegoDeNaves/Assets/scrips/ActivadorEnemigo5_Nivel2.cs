using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorEnemigo5_Nivel2 : MonoBehaviour
{

    // Use this for initialization
    private int activacion;
    public GameObject Enemigo1;
    public GameObject Enemigo2;
    public GameObject Enemigo3;
    public GameObject Enemigo4;
    public GameObject Enemigo5;
    public GameObject Enemigo6;
    public GameObject Enemigo7;
    public GameObject Enemigo8;
    public GameObject Enemigo9;
    public GameObject Enemigo10;
    public GameObject Enemigo11;
    public GameObject Enemigo12;
    public GameObject Enemigo13;
    public GameObject Enemigo14;
    public GameObject Enemigo15;
    public GameObject Enemigo16;
    public GameObject Enemigo17;
    public GameObject Enemigo18;
    public GameObject Enemigo19;
    public GameObject Enemigo20;
    public GameObject Enemigo21;
    public GameObject Enemigo22;
    public GameObject Enemigo23;
    public GameObject Enemigo24;
    public GameObject Enemigo25;
    public GameObject Enemigo26;
    public GameObject Enemigo27;

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
            if (Enemigo1 != null)
            {
                Enemigo1.SetActive(true);
            }
            if (Enemigo2 != null)
            {
                Enemigo2.SetActive(true);
            }
            if (Enemigo3 != null)
            {
                Enemigo3.SetActive(true);
            }
            if (Enemigo4 != null)
            {
                Enemigo4.SetActive(true);
            }
            if (Enemigo5 != null)
            {
                Enemigo5.SetActive(true);
            }
            if (Enemigo6 != null)
            {
                Enemigo6.SetActive(true);
            }
            if (Enemigo7 != null)
            {
                Enemigo7.SetActive(true);
            }
            if (Enemigo8 != null)
            {
                Enemigo8.SetActive(true);
            }
            if (Enemigo9 != null)
            {
                Enemigo9.SetActive(true);
            }
            if (Enemigo10 != null)
            {
                Enemigo10.SetActive(true);
            }
            if (Enemigo11 != null)
            {
                Enemigo11.SetActive(true);
            }
            if (Enemigo12 != null)
            {
                Enemigo12.SetActive(true);
            }
            if (Enemigo13 != null)
            {
                Enemigo13.SetActive(true);
            }
            if (Enemigo14 != null)
            {
                Enemigo14.SetActive(true);
            }
            if (Enemigo15 != null)
            {
                Enemigo15.SetActive(true);
            }
            if (Enemigo16 != null)
            {
                Enemigo16.SetActive(true);
            }
            if (Enemigo17 != null)
            {
                Enemigo17.SetActive(true);
            }
            if (Enemigo18 != null)
            {
                Enemigo18.SetActive(true);
            }
            if (Enemigo19 != null)
            {
                Enemigo19.SetActive(true);
            }
            if (Enemigo20 != null)
            {
                Enemigo20.SetActive(true);
            }
            if (Enemigo21 != null)
            {
                Enemigo21.SetActive(true);
            }
            if (Enemigo22 != null)
            {
                Enemigo22.SetActive(true);
            }
            if (Enemigo23 != null)
            {
                Enemigo23.SetActive(true);
            }
            if (Enemigo24 != null)
            {
                Enemigo24.SetActive(true);
            }
            if (Enemigo25 != null)
            {
                Enemigo25.SetActive(true);
            }
            if (Enemigo26 != null)
            {
                Enemigo26.SetActive(true);
            }
            if (Enemigo27 != null)
            {
                Enemigo27.SetActive(true);
            }
        }
        if (other.gameObject.tag == "Jugador")
        {
            activacion = 1;
        }
    }
}
