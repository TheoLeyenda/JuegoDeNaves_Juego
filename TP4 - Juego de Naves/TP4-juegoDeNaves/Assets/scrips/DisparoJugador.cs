using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour {

    // Use this for initialization
    public Transform spawnBala;
    public GameObject Bala;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(Bala, new Vector3(spawnBala.position.x,spawnBala.position.y+0.8f,spawnBala.position.z), Quaternion.identity);
        }
	}
}
