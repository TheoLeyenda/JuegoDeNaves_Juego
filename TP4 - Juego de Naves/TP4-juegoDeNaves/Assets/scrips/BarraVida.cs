using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class BarraVida : MonoBehaviour {

	public Scrollbar BarraDeVida;
	public float Vida = 100;
    private float danio = 0.5f;
    private float sanacion = 0;
    void Update()
    {
        if(Vida<0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("EscenaFinal");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BalaEnemigo")
        {
            danio = 1;
            Vida -= danio;
            BarraDeVida.size = Vida / 100f;
            danio = 0.5f;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Enemigo")
        {
            danio = 5;
            Vida -= danio;
            BarraDeVida.size = Vida / 100f;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "ItemVida")
        {
            sanacion = 100;
            Vida = sanacion;
            BarraDeVida.size = Vida ;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "ItemPoder")
        {
            if (GameManager.tipoDisparo < 3)
            {
                GameManager.tipoDisparo++;
            }
            Destroy(other.gameObject);
        }
        
    }
   

}
