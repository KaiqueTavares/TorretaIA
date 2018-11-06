using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour {

    public float velocidade;
    public float tempoVida;
	
    void Start()
    {
        // Destruir o projetil por tempo
        Destroy(gameObject, tempoVida);
    }
    
	void Update () {
        // Move o projetil
        transform.Translate(Vector3.forward * velocidade * Time.deltaTime);	      	
	}

    void OnCollisionEnter()
    {
        // Destruir o projetil por colsai
        Destroy(gameObject);
    }

}
