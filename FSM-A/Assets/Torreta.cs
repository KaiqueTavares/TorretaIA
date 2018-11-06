using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour {

    public Transform disparador;
    public float velocidadeRotation;
    public float visaoDistancia;
    public float limiteRotacao;

    private Ray ray;
    private RaycastHit hit;
    private float rotacaoAtual;

    public static bool atirar;
    

	void Update () {

        // Debug Raycast
        Vector3 front = disparador.transform.TransformDirection(Vector3.forward) * visaoDistancia;
        Debug.DrawRay(disparador.transform.position, front, Color.red);

        // Colisao do Raycast em relacao o objeto
        if (Physics.Raycast(disparador.transform.position, front, out hit))
        {
            if(hit.collider.tag == "Jogador")
            {
                atirar = true;
                GameObject obj = hit.collider.gameObject;
                transform.LookAt(obj.transform);
            }
            else if (hit.collider.tag == "Untagged")
            {
                atirar = false;
            }

        }
        else
        {
            atirar = false;
        }
        

        // Rotacao da torret
        if (!atirar)
        {
            rotacaoAtual += velocidadeRotation;
            transform.eulerAngles = new Vector3(0.0f, rotacaoAtual, 0.0f);

            if (Mathf.Abs(rotacaoAtual) == 45)
            {
                velocidadeRotation *= -1;
            }
        }       
        
    }
}
