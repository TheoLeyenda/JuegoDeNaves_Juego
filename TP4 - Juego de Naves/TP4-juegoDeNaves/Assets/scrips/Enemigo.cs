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
    public GameObject refBalaEnemigoTip1;
    public GameObject refBalaEnemigoTip2;
    public GameObject refBalaEnemigoTip3;
    public GameObject refBalaEnemigoTip4;
    public GameObject refBalaEnemigoTip5;
    public GameObject refBalaEnemigoTip6;
    public GameObject refBalaEnemigoTip7;
    public GameObject refBalaEnemigoTip8;
    public GameObject refBalaEnemigoTip9;
    public GameObject refItemVidaGigante;
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
    private float maxDerecha;
    private float maxIzquierda;
    public bool quietos;
    private float dileyDisparoPatron6;
    private static Enemigo instance;
    private float randDisparo;
    public bool rapidoPatron5;
    public bool rapidoPatron4;
    public bool rapidoPatron2;
    public bool disparoRapidoPatron4;
    bool soloUnaVez;
    void Start() {
        vida = 100;
        movimientoX = 0;
        movimientoY = 0;
        velocidadX = 0.1f;
        velocidadY = 0.1f;
        //tiempoAntesDeDoblar1 = 2;
        rotacionCurvaMov1 = 0.0050f;
        empezarSegundaCurvaMov1 = 6;
        primerCurvaMov1 = true;
        segundaCurvaMov1 = true;
        inicialX = transform.position.x;
        inicialY = transform.position.y;
        asignarDiley = 0.8f;// cada este tiepoDisparara
        dileyDisparo = asignarDiley;
        empezarCurvaMov2 = 11;
        dileyCambioDireccion = 1;
        soloUnaVez = true;
        maxDerecha = 9;
        maxIzquierda = -9;
        dileyDisparoPatron6 = 0.8f;
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
                if (transform.position.y > (refCamara.transform.position.y + 20))
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
                        if (!rapidoPatron2)
                        {
                            velocidadY = -0.025f;
                            velocidadX = 0.1f;
                            soloUnaVez = false;
                            doblarIzquierda = false;
                            doblarDerecha = true;
                        }
                        else if (rapidoPatron2)
                        {
                            velocidadY = -0.025f;
                            velocidadX = 0.2f;
                            soloUnaVez = false;
                            doblarIzquierda = false;
                            doblarDerecha = true;
                        }

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
                        if (!rapidoPatron2)
                        {
                            velocidadY = -0.025f;
                            velocidadX = -0.1f;
                            soloUnaVez = false;
                            doblarIzquierda = true;
                            doblarDerecha = false;
                        }
                        else if (rapidoPatron2)
                        {
                            velocidadY = -0.025f;
                            velocidadX = -0.2f;
                            soloUnaVez = false;
                            doblarIzquierda = true;
                            doblarDerecha = false;
                        }

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
                
                if (!rapidoPatron4)
                {
                    movimientoX = 0;
                    movimientoY = -0.015f;
                }
                if (disparoRapidoPatron4 && soloUnaVez)
                {
                    asignarDiley = 0.1f;
                    dileyDisparo = asignarDiley;
                    soloUnaVez = false;
                }
                else if (rapidoPatron4)
                {
                    movimientoX = 0;
                    movimientoY = -0.2f;
                }
                transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
                if (dileyDisparo > 0)
                {
                    dileyDisparo = dileyDisparo - Time.deltaTime;
                }
                if ((movimientoX == 0 || velocidadX == 0) && dileyDisparo <= 0)
                {
                    Debug.Log("Ddisparo");
                    Instantiate(refBalaEnemigo, transform.position, transform.rotation);
                    dileyDisparo = asignarDiley;
                    if (disparoRapidoPatron4)
                    {
                        asignarDiley = 0.1f;
                        dileyDisparo = asignarDiley;
                    }
                }
            }
            if (tipoEnemigo == 5)
            {
                if (inicialX > 0)
                {
                    if (!rapidoPatron5)
                    {
                        movimientoX = -0.1f;
                        transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
                    }
                    else if (rapidoPatron5)
                    {
                        movimientoX = -0.3f;
                        transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
                    }
                }
                if (inicialX < 0)
                {
                    if (!rapidoPatron5)
                    {
                        movimientoX = 0.1f;
                        transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
                    }
                    else if (rapidoPatron5)
                    {
                        movimientoX = 0.3f;
                        transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
                    }
                }
            }
            if (tipoEnemigo == 6)
            {
                if (dileyDisparoPatron6 > 0)
                {
                    dileyDisparoPatron6 = dileyDisparoPatron6 - Time.deltaTime;
                }
                if (dileyDisparoPatron6 <= 0)
                {
                    Instantiate(refBalaEnemigo, transform.position, transform.rotation);
                    dileyDisparoPatron6 = 0.8f;
                }
                if (inicialX > 0 && soloUnaVez)
                {
                    movimientoX = -0.1f;
                    soloUnaVez = false;
                }
                if (transform.position.x > maxDerecha)
                {
                    movimientoX = -0.1f;
                }
                if (transform.position.x < maxIzquierda)
                {
                    movimientoX = 0.1f;
                }
                if (inicialX < 0 && soloUnaVez)
                {
                    movimientoX = 0.1f;
                    soloUnaVez = false;
                }
                transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);

            }
            if (tipoEnemigo == 7)
            {
                if (soloUnaVez)
                {
                    velocidadY = 0;
                    velocidadX = 0.1f;
                    soloUnaVez = false;
                }
                if (transform.position.x > 13)
                {
                    Debug.Log("Entre a izquierda");
                    velocidadX = -0.1f;
                    velocidadY = velocidadY + -0.1f;
                }
                if (transform.position.x < -13)
                {
                    Debug.Log("Entre a Derecha");
                    velocidadX = 0.1f;
                    velocidadY = velocidadY + -0.1f;
                }
                randDisparo = Random.Range(0, 1000);
                if(randDisparo == 2)
                {
                    Instantiate(refBalaEnemigo, transform.position, transform.rotation);
                }
                movimientoX = velocidadX;
                movimientoY = velocidadY;
                transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y+movimientoY);
                velocidadY = 0;
                velocidadY = 0;
            }
            //PATRONES NUEVOS PARA NVIEL 2
            //ENEMIGO QUE VA PARA ABAJO Y DISPARA DOS BALAS.
            if(tipoEnemigo == 8)
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
                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x-0.2f,transform.position.y,transform.position.z), transform.rotation);
                    dileyDisparo = asignarDiley;
                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x+ 0.2f, transform.position.y, transform.position.z), transform.rotation);

                }
            }
            //ENEMIGO QUE VA PARA ARRIBA Y DISPARA
            if (tipoEnemigo == 9)
            {
                movimientoX = 0;
                movimientoY = 0.2f;
                transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
                if (dileyDisparo > 0)
                {
                    dileyDisparo = dileyDisparo - Time.deltaTime;
                }
                if ((movimientoX == 0 || velocidadX == 0) && dileyDisparo <= 0)
                {
                    Instantiate(refBalaEnemigoTip6, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
                    dileyDisparo = asignarDiley;

                }

            }
            //VA PARA ABAJO Y DISPARA PARA ABAJO Y PARA LA DERECHA
            if (tipoEnemigo == 10)
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
                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x - 0.2f, transform.position.y, transform.position.z), transform.rotation);
                    
                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x + 0.2f, transform.position.y, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigoTip5, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);

                    dileyDisparo = asignarDiley;
                }
            }
            //VA PARA ABAJO Y DISPARA PARA ABAJO Y PARA LA IZQUIERDA
            if (tipoEnemigo == 11)
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
                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x - 0.2f, transform.position.y, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x + 0.2f, transform.position.y, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigoTip4, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);

                    dileyDisparo = asignarDiley;
                }
            }
            // VA PARA ABAJO Y DISPARA PARA ABAJO Y PARA SUS DOS DIAGONALES
            if (tipoEnemigo == 12)
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
                    Instantiate(refBalaEnemigoTip2, new Vector3(transform.position.x - 0.2f, transform.position.y, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigoTip3, new Vector3(transform.position.x + 0.2f, transform.position.y, transform.position.z), transform.rotation);

                    dileyDisparo = asignarDiley;
                }
            }
            // SE MUEVE DE IZQUIERDA A DERECHA Y DISPARA PARA SUS DOS DAIGONALES Y ABAJO
            if (tipoEnemigo == 13)
            {
                if (dileyDisparoPatron6 > 0)
                {
                    dileyDisparoPatron6 = dileyDisparoPatron6 - Time.deltaTime;
                }
                if (dileyDisparoPatron6 <= 0)
                {
                    Instantiate(refBalaEnemigoTip2, new Vector3(transform.position.x - 0.2f, transform.position.y - 0.8f, transform.position.z), transform.rotation);
                    Instantiate(refBalaEnemigo, transform.position, transform.rotation);
                    Instantiate(refBalaEnemigoTip3, new Vector3(transform.position.x + 0.2f, transform.position.y - 0.8f, transform.position.z), transform.rotation);

                    dileyDisparoPatron6 = 0.8f;
                }
                if (inicialX > 0 && soloUnaVez)
                {
                    movimientoX = -0.1f;
                    soloUnaVez = false;
                }
                if (transform.position.x > maxDerecha)
                {
                    movimientoX = -0.1f;
                }
                if (transform.position.x < maxIzquierda)
                {
                    movimientoX = 0.1f;
                }
                if (inicialX < 0 && soloUnaVez)
                {
                    movimientoX = 0.1f;
                    soloUnaVez = false;
                }
                transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
            }
            if (tipoEnemigo == 14)
            {
                movimientoX = 0;
                movimientoY = -0.2f;
                transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
            }
            //SE MUEVE DE IZQUIERDA A DERECHA Y DISPARA PARA ABAJO
            if (tipoEnemigo == 15)
            {
                if (dileyDisparoPatron6 > 0)
                {
                    dileyDisparoPatron6 = dileyDisparoPatron6 - Time.deltaTime;
                }
                if (dileyDisparoPatron6 <= 0)
                {
                    Instantiate(refBalaEnemigoTip3, new Vector3(transform.position.x - 0.8f, transform.position.y - 0.8f, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x - 0.5f, transform.position.y - 0.8f, transform.position.z), transform.rotation);
                    
                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x + 0.5f, transform.position.y - 0.8f, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigoTip2, new Vector3(transform.position.x + 0.8f, transform.position.y - 0.8f, transform.position.z), transform.rotation);
                    dileyDisparoPatron6 = 0.8f;
                }
                if (inicialX > 0 && soloUnaVez)
                {
                    movimientoX = -0.1f;
                    soloUnaVez = false;
                }
                if (transform.position.x > maxDerecha)
                {
                    movimientoX = -0.1f;
                }
                if (transform.position.x < maxIzquierda)
                {
                    movimientoX = 0.1f;
                }
                if (inicialX < 0 && soloUnaVez)
                {
                    movimientoX = 0.1f;
                    soloUnaVez = false;
                }
                transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
            }
            if (tipoEnemigo == 16)
            {
                if (dileyDisparoPatron6 > 0)
                {
                    dileyDisparoPatron6 = dileyDisparoPatron6 - Time.deltaTime;
                }
                if (dileyDisparoPatron6 <= 0)
                {
                    Instantiate(refBalaEnemigoTip2, new Vector3(transform.position.x - 2.24f, transform.position.y - 0.8f, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigoTip2, new Vector3(transform.position.x - 1.60f, transform.position.y - 0.8f, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigoTip2, new Vector3(transform.position.x - 0.96f, transform.position.y - 0.8f, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x - 3.64f, transform.position.y - 0.8f, transform.position.z), transform.rotation);
                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x - 3, transform.position.y - 0.8f, transform.position.z), transform.rotation);
                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x - 2.36f, transform.position.y - 0.8f, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x - 1.60f, transform.position.y - 0.8f, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x - 0.96f, transform.position.y - 0.8f, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x - 0.32f, transform.position.y - 0.8f, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x + 0.32f, transform.position.y - 0.8f, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x + 0.96f, transform.position.y - 0.8f, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x + 1.60f, transform.position.y - 0.8f, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x + 3, transform.position.y - 0.8f, transform.position.z), transform.rotation);
                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x + 3.64f, transform.position.y - 0.8f, transform.position.z), transform.rotation);
                    Instantiate(refBalaEnemigo, new Vector3(transform.position.x + 2.36f, transform.position.y - 0.8f, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigoTip3, new Vector3(transform.position.x + 0.96f, transform.position.y - 0.8f, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigoTip3, new Vector3(transform.position.x + 1.60f, transform.position.y - 0.8f, transform.position.z), transform.rotation);

                    Instantiate(refBalaEnemigoTip3, new Vector3(transform.position.x + 2.24f, transform.position.y - 0.8f, transform.position.z), transform.rotation);

                    dileyDisparoPatron6 = 0.8f;
                }
                if (inicialX > 0 && soloUnaVez)
                {
                    movimientoX = -0.1f;
                    soloUnaVez = false;
                }
                if (transform.position.x > maxDerecha)
                {
                    movimientoX = -0.1f;
                }
                if (transform.position.x < maxIzquierda)
                {
                    movimientoX = 0.1f;
                }
                if (inicialX < 0 && soloUnaVez)
                {
                    movimientoX = 0.1f;
                    soloUnaVez = false;
                }
                transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
            }
            if (tipoEnemigo == 17)
            {
                /*if (refBalaEnemigoTip7 != null && refBalaEnemigoTip8 != null /*&& refBalaEnemigoTip9 != null)
                {*/
                    if (dileyDisparoPatron6 > 0)
                    {
                        dileyDisparoPatron6 = dileyDisparoPatron6 - Time.deltaTime;
                    }
                    if (dileyDisparoPatron6 <= 0)
                    {
                        //ACA INSTANCIAR LOS DISPAROS DEL ENEMIGO FINAL.
                        Debug.Log("Instanciado Balas ENemigo final");
                        Instantiate(refBalaEnemigoTip8, transform.position, transform.rotation);
                        Instantiate(refBalaEnemigoTip7, transform.position, transform.rotation);
                        dileyDisparoPatron6 = 0.8f;
                    }
                    if (inicialX > 0 && soloUnaVez)
                    {
                        movimientoX = -0.1f;
                        soloUnaVez = false;
                    }
                    if (transform.position.x > maxDerecha)
                    {
                        movimientoX = -0.1f;
                    }
                    if (transform.position.x < maxIzquierda)
                    {
                        movimientoX = 0.1f;
                    }
                    if (inicialX < 0 && soloUnaVez)
                    {
                        movimientoX = 0.1f;
                        soloUnaVez = false;
                    }
                    transform.position = new Vector2(transform.position.x + movimientoX, transform.position.y + movimientoY);
                //}
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
    public float GetVida()
    {
        return vida;
    }
    public void SetVida(float _vida)
    {
        vida = _vida;
    }
    //VERIFICAR SI ESTO FUNCIONA USANDO DE PRUEBA A LOS ENEMIGOS CON VIDA
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bala" && this.gameObject.tag == "EnemigoResistente")
        {
            vida = vida - 1;
            if (vida <= 0)
            {
                if (refItemVidaGigante != null)
                {
                    Instantiate(refItemVidaGigante, transform.position, Quaternion.identity);
                }
                Destroy(this.gameObject);
            }
            Destroy(other.gameObject);

        }
    }
}
