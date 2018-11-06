using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour {

    public GameObject projetilPrefab;
    	
	IEnumerator Start () {

        yield return new WaitForSeconds(0.3f);

        if (Torreta.atirar) {            
            Instantiate(projetilPrefab, transform.position, transform.rotation);
        }

        StartCoroutine(Start());

	}
}
