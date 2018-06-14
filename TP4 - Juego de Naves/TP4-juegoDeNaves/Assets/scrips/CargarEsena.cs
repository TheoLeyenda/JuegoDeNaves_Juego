using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarEsena : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void LoadTexto_nivel1()
    {
        SceneManager.LoadScene("Texto_Nivel1");
    }
    public void LoadTexto_nivel2()
    {
        SceneManager.LoadScene("Texto_Nivel2");
    }
    public void LoadNivel1()
    {
        SceneManager.LoadScene("Nivel1");
    }
    public void LoadNivel2()
    {
        SceneManager.LoadScene("Nivel2");
    }
    public void LoadEscenaFinal()
    {
        SceneManager.LoadScene("EscenaFinal");
    }
}
