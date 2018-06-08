using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class BarraVida : MonoBehaviour {

	public Scrollbar BarraDeVida;
	public float Vida = 100;
    private float danio = 0.5f;
    void Update()
    {
        if(Vida<0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("EscenaFinal");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemigo")
        {
            Vida -= danio;
            BarraDeVida.size = Vida / 100f;
        }
    }

}
