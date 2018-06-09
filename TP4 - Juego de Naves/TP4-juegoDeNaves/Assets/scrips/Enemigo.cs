using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

    // Use this for initialization
    public int tipoEnemigo;
    private float movimientoY;
    private float movimientoX;
    private float velocidadX;
    private float velocidadY;
    private float inicialX;
    private float inicialY;
    public float tiempoAntesDeDoblar1;
    private float tiempoAntesDeDoblar2;
    private float tiempoAntesDeDoblar3;
    private float empezarSegundaCurvaMov1;
    private float rotacionCurvaMov1;
    private bool primerCurvaMov1;
    private bool segundaCurvaMov1;
    private float varAux1 = 0.01f;//NO TOCAR
    private float varAux2 = 0.001f;//NO TOCAR
    private float vida;
	void Start () {
        vida = 100;
        movimientoX = 0;
        movimientoY = 0;
        velocidadX = 0.1f;
        velocidadY = 0.1f;
        //tiempoAntesDeDoblar1 = 2;
        rotacionCurvaMov1 = 0.0050f;
        empezarSegundaCurvaMov1 = 9;
        primerCurvaMov1 = true;
        segundaCurvaMov1 = true;
        inicialX = transform.position.x;
        inicialY = transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {
        if (tipoEnemigo == 1)
        {
            
            if (tiempoAntesDeDoblar1 > 0)
            {
                tiempoAntesDeDoblar1 = tiempoAntesDeDoblar1 - Time.deltaTime;
                movimientoY = -velocidadY;
            }
            if (inicialX < 0)
            {
                if (inicialX < 0 && tiempoAntesDeDoblar1 <= 0)
                {
                    movimientoX = velocidadX;
                    if (movimientoY <= varAux1 && primerCurvaMov1)
                    {
                        movimientoY = movimientoY + rotacionCurvaMov1;
                    }
                    if (movimientoY >= varAux2 && primerCurvaMov1)
                    {
                        primerCurvaMov1 = false;
                        movimientoY = 0;
                    }

                    transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
                }
                if (transform.position.x >= empezarSegundaCurvaMov1)
                {
                    if (movimientoY <= 0.1 && segundaCurvaMov1)
                    {
                        movimientoY = movimientoY + rotacionCurvaMov1;
                    }
                    if (movimientoY >= 0.1f)
                    {
                        // segundaCurvaMov1 = false;
                        velocidadX = 0;
                        movimientoY = velocidadY;
                    }
                }
            }
            if (inicialX > 0)
            {
                if (inicialX > 0 && tiempoAntesDeDoblar1 <= 0)
                {
                    movimientoX = -velocidadX;
                    if (movimientoY <= varAux1 && primerCurvaMov1)
                    {
                        movimientoY = movimientoY + rotacionCurvaMov1;
                    }
                    if (movimientoY >= varAux2 && primerCurvaMov1)
                    {
                        primerCurvaMov1 = false;
                        movimientoY = 0;
                    }

                    transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
                }
                if (transform.position.x <= empezarSegundaCurvaMov1*-1)
                {
                    if (movimientoY <= 0.1 && segundaCurvaMov1)
                    {
                        movimientoY = movimientoY + rotacionCurvaMov1;
                    }
                    if (movimientoY >= 0.1f)
                    {
                        // segundaCurvaMov1 = false;
                        velocidadX = 0;
                        movimientoY = velocidadY;
                    }
                }
            }
            transform.position = new Vector2(transform.position.x+movimientoX, transform.position.y+movimientoY);
        }
        if (tipoEnemigo == 2)
        {

        }
	}
}
