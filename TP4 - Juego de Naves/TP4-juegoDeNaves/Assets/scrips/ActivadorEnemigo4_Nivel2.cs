using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorEnemigo4_Nivel2 : MonoBehaviour
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
        }
        if (other.gameObject.tag == "Jugador")
        {
            activacion = 1;
        }
    }
}
