using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

    // Use this for initialization
    public int tipoEnemigo;
    //public GameObject instanciador;
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
    private float empezarCurvaMov2;
    public float velocidadRotacion;
    private float rotacionCurvaMov1;
    private bool primerCurvaMov1;
    public GameObject refBalaEnemigo;
    public Camera refCamara;
    private bool segundaCurvaMov1;
    private float varAux1 = 0.01f;//NO TOCAR
    private float varAux2 = 0.001f;//NO TOCAR
    private float vida;
    private float dileyDisparo;
    private float dileyCambioDireccion;
    private bool doblarIzquierda;
    private bool doblarDerecha;
    private float asignarDiley;
    public bool quietos;
    private static Enemigo instance;
    bool soloUnaVez;
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
        asignarDiley = 0.8f;// cada este tiepoDisparara
        dileyDisparo = asignarDiley;
        empezarCurvaMov2 =11;
        dileyCambioDireccion = 1;
        soloUnaVez = true;

        //tipoEnemigo = 0;
    }
    private void Awake()
    {
        instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        // tipoEnemigo = GameManager.Get().tipoEnemigo;
        if (!quietos)
        {
            transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
            if (transform.position.y < (refCamara.transform.position.y + 25) * -1 || transform.position.x > refCamara.pixelWidth + 10 || transform.position.x < (refCamara.pixelWidth + 10) * -1)
            {
                Destroy(this.gameObject);
            }
            if (tipoEnemigo == 1)
            {
                if(transform.position.y> (refCamara.transform.position.y + 20))
                {
                    Destroy(this.gameObject);
                }
                if (tiempoAntesDeDoblar1 > 0)
                {
                    tiempoAntesDeDoblar1 = tiempoAntesDeDoblar1 - Time.deltaTime;
                    movimientoY = -velocidadY;
                }
                if (inicialX < 0)
                {
                    if (dileyDisparo > 0)
                    {
                        dileyDisparo = dileyDisparo - Time.deltaTime;
                    }
                    if (inicialX < 0 && tiempoAntesDeDoblar1 <= 0)
                    {
                        movimientoX = velocidadX;
                        if (movimientoY <= varAux1 && primerCurvaMov1)
                        {
                            movimientoY = movimientoY + rotacionCurvaMov1;
                            transform.RotateAround(transform.position, transform.right * -1, velocidadRotacion * Time.deltaTime);
                            //transform.RotateAroundLocal(transform.up * -1, velocidadRotacion * Time.deltaTime);
                            //transform.Rotate(new Vector3(0f, 30f, 0f)*Time.deltaTime);

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
                            transform.RotateAround(transform.position, transform.right * -1, velocidadRotacion * Time.deltaTime);
                            //transform.RotateAroundLocal(transform.up * -1, velocidadRotacion * Time.deltaTime);
                            //transform.Rotate(new Vector3(0f, 30f, 0f) * Time.deltaTime);
                        }
                        if (movimientoY >= 0.1f)
                        {
                            // segundaCurvaMov1 = false;
                            velocidadX = 0;
                            movimientoY = velocidadY;
                        }
                    }
                    if ((movimientoX == 0 || velocidadX == 0) && dileyDisparo <= 0)
                    {
                        Instantiate(refBalaEnemigo, transform.position, transform.rotation);
                        dileyDisparo = asignarDiley;
                    }
                }
                if (inicialX > 0)
                {

                    if (dileyDisparo > 0)
                    {
                        dileyDisparo = dileyDisparo - Time.deltaTime;
                    }
                    if (inicialX > 0 && tiempoAntesDeDoblar1 <= 0)
                    {
                        movimientoX = -velocidadX;
                        if (movimientoY <= varAux1 && primerCurvaMov1)
                        {
                            movimientoY = movimientoY + rotacionCurvaMov1;
                            transform.RotateAround(transform.position, transform.up * -1, velocidadRotacion * Time.deltaTime);
                            //transform.RotateAroundLocal(transform.up * -1, velocidadRotacion * Time.deltaTime);
                            //transform.Rotate(new Vector3(0f, 30f, 0f) * Time.deltaTime);
                        }
                        if (movimientoY >= varAux2 && primerCurvaMov1)
                        {
                            primerCurvaMov1 = false;
                            movimientoY = 0;
                        }

                        transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
                    }
                    if (transform.position.x <= empezarSegundaCurvaMov1 * -1)
                    {
                        if (movimientoY <= 0.1 && segundaCurvaMov1)
                        {
                            movimientoY = movimientoY + rotacionCurvaMov1;
                            transform.RotateAround(transform.position, transform.right * -1, velocidadRotacion * Time.deltaTime);
                            //transform.RotateAroundLocal(transform.up * -1, velocidadRotacion * Time.deltaTime);
                            //transform.Rotate(new Vector3(0f, 30f, 0f) * Time.deltaTime);
                        }
                        if (movimientoY >= 0.1f)
                        {
                            // segundaCurvaMov1 = false;
                            velocidadX = 0;
                            movimientoY = velocidadY;
                        }
                    }
                    if ((movimientoX == 0 || velocidadX == 0) && dileyDisparo <= 0)
                    {
                        Instantiate(refBalaEnemigo, transform.position, transform.rotation);
                        dileyDisparo = asignarDiley;
                    }
                }

            }
            if (tipoEnemigo == 2)
            {

                transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
                if (inicialX < 0)
                {
                    if (inicialX < 0 && soloUnaVez)
                    {
                        velocidadY = -0.025f;
                        velocidadX = 0.1f;
                        soloUnaVez = false;
                        doblarIzquierda = false;
                        doblarDerecha = true;

                    }
                    if (transform.position.x >= empezarCurvaMov2 && doblarDerecha)
                    {
                        velocidadX = velocidadX * -1;
                        dileyCambioDireccion = 0;
                        doblarDerecha = false;
                        doblarIzquierda = true;
                    }
                    if (transform.position.x <= -empezarCurvaMov2 && doblarIzquierda)
                    {
                        velocidadX = velocidadX * -1;
                        dileyCambioDireccion = 0;
                        doblarIzquierda = false;
                        doblarDerecha = true;
                    }
                    if (dileyCambioDireccion <= 1f)
                    {
                        dileyCambioDireccion = dileyCambioDireccion + Time.deltaTime;
                    }
                    movimientoX = velocidadX;
                    movimientoY = velocidadY;
                }
                if (inicialX > 0)
                {
                    if (inicialX > 0 && soloUnaVez)
                    {
                        velocidadY = -0.025f;
                        velocidadX = -0.1f;
                        soloUnaVez = false;
                        doblarIzquierda = true;
                        doblarDerecha = false;

                    }
                    if (transform.position.x >= empezarCurvaMov2 && doblarDerecha)
                    {
                        velocidadX = velocidadX * -1;
                        dileyCambioDireccion = 0;
                        doblarDerecha = false;
                        doblarIzquierda = true;
                    }
                    if (transform.position.x <= -empezarCurvaMov2 && doblarIzquierda)
                    {
                        velocidadX = velocidadX * -1;
                        dileyCambioDireccion = 0;
                        doblarIzquierda = false;
                        doblarDerecha = true;
                    }
                    if (dileyCambioDireccion <= 1f)
                    {
                        dileyCambioDireccion = dileyCambioDireccion + Time.deltaTime;
                    }
                    movimientoX = velocidadX;
                    movimientoY = velocidadY;
                }
            }
            if (tipoEnemigo == 3)
            {
                if (inicialX < 0)
                {
                    transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
                    movimientoY = -0.2f;
                    movimientoX = 0.20f;
                }
                if (inicialX > 0)
                {
                    transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
                    movimientoY = -0.2f;
                    movimientoX = -0.20f;
                }

            }
            if (tipoEnemigo == 4)
            {
                movimientoX = 0;
                movimientoY = -0.015f;
                transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
                if (dileyDisparo > 0)
                {
                    dileyDisparo = dileyDisparo - Time.deltaTime;
                }
                if ((movimientoX == 0 || velocidadX == 0) && dileyDisparo <= 0)
                {
                    Instantiate(refBalaEnemigo, transform.position, transform.rotation);
                    dileyDisparo = asignarDiley;
                }
            }
            if (tipoEnemigo == 5)
            {
                if (inicialX > 0)
                {
                    movimientoX = -0.1f;
                    transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
                }
                if (inicialX < 0)
                {
                    movimientoX = 0.1f;
                    transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
                }
            }
        }
    }
    public void SetQuieto(bool _quietos)
    {
        quietos = _quietos;
    }
    public static Enemigo Get()
    {
        return instance;
    }
}
