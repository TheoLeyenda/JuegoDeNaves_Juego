using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour {

    // Use this for initialization
    //USAR LA MISMA LOGICA DE LAS BALAS PARA HACER LAS BOMBAS :3
    public Transform spawnBala;
    public GameObject TipoBala1;
    public GameObject TipoBala2;
    public GameObject TipoBala3;
    public GameObject TipoBala4;
    public GameObject TipoBala5;
    public GameObject bombaJugador;
    public GameObject SpriteBomba1;
    public GameObject SpriteBomba2;
    public GameObject SpriteBomba3;
    public AudioClip audioDisparo;
    public AudioClip audioExplocion;
    private RaycastHit hit;
    public float rango;
    private int cantBombas;
    AudioSource fuenteAudio;
	void Start () {
        fuenteAudio = GetComponent<AudioSource>();
        DontDestroyOnLoad(this);
        cantBombas = 3;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (fuenteAudio != null)
            {
                fuenteAudio.clip = audioDisparo;
                fuenteAudio.Play();
            }
            if (GameManager.tipoDisparo == 1)
            {
                //GameManager.tipoBala = 1;
                Instantiate(TipoBala1, new Vector3(spawnBala.position.x, spawnBala.position.y + 0.8f, spawnBala.position.z), Quaternion.identity);
                rango = 100;
            }
           if (GameManager.tipoDisparo == 2)
            {
                Instantiate(TipoBala1, new Vector3(spawnBala.position.x+0.2f, spawnBala.position.y + 0.8f, spawnBala.position.z), Quaternion.identity);
                Instantiate(TipoBala1, new Vector3(spawnBala.position.x -0.2f, spawnBala.position.y + 0.8f, spawnBala.position.z), Quaternion.identity);
            }
            if (GameManager.tipoDisparo == 3)
            {
                
                Instantiate(TipoBala1, new Vector3(spawnBala.position.x + 0.2f, spawnBala.position.y + 0.8f, spawnBala.position.z), Quaternion.identity);
                Instantiate(TipoBala1, new Vector3(spawnBala.position.x - 0.2f, spawnBala.position.y + 0.8f, spawnBala.position.z), Quaternion.identity);
                Instantiate(TipoBala2, new Vector3(spawnBala.position.x + 0.4f, spawnBala.position.y + 0.8f, spawnBala.position.z), Quaternion.identity);
                Instantiate(TipoBala3, new Vector3(spawnBala.position.x + -0.4f, spawnBala.position.y + 0.8f, spawnBala.position.z), Quaternion.identity);
                
            }
            if (GameManager.tipoDisparo == 4)
            {
                Instantiate(TipoBala1, new Vector3(spawnBala.position.x + 0.2f, spawnBala.position.y + 0.8f, spawnBala.position.z), Quaternion.identity);
                Instantiate(TipoBala1, new Vector3(spawnBala.position.x - 0.2f, spawnBala.position.y + 0.8f, spawnBala.position.z), Quaternion.identity);
                Instantiate(TipoBala2, new Vector3(spawnBala.position.x + 0.4f, spawnBala.position.y + 0.8f, spawnBala.position.z), Quaternion.identity);
                Instantiate(TipoBala3, new Vector3(spawnBala.position.x + -0.4f, spawnBala.position.y + 0.8f, spawnBala.position.z), Quaternion.identity);
                Instantiate(TipoBala4, new Vector3(spawnBala.position.x + -0.5f, spawnBala.position.y, spawnBala.position.z), Quaternion.identity);
                Instantiate(TipoBala5, new Vector3(spawnBala.position.x + 0.5f, spawnBala.position.y, spawnBala.position.z), Quaternion.identity);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && cantBombas>0)
        {
            Debug.Log("EXplotion");
            if (fuenteAudio != null)
            {
                fuenteAudio.clip = audioExplocion;
                fuenteAudio.Play();
            }
            bombaJugador.SetActive(true);
            if (cantBombas == 3)
            {
                SpriteBomba1.SetActive(false);
            }
            if (cantBombas == 2)
            {
                SpriteBomba2.SetActive(false);
            }
            if (cantBombas == 1)
            {
                SpriteBomba3.SetActive(false);
            }
            cantBombas--;
        }
        
	}
    
}
