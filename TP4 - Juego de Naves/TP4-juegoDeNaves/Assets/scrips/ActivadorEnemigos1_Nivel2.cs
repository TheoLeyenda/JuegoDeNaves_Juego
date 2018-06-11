using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorEnemigos1_Nivel2 : MonoBehaviour
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
        }
        if (other.gameObject.tag == "Jugador")
        {
            activacion = 1;
        }
    }

}
