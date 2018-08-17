using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso : MonoBehaviour {

    public float limiteX;
    public float retornarX;
    public float velocidade;

    	
	void Update () {

        if (FlappyBird.jogando)
        {
            // Verifica se chegou no limite da tela
            if (transform.position.x < limiteX)
            {
                // Retorna para um novo ciclo
                transform.position = new Vector3(retornarX,
                    transform.position.y, 0.0f);
            }

            // Move o piso
            transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        }     
        		
	}
}
