using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cano : MonoBehaviour {

    public float velocidade;    
    public float limiteSuperior, limiteInferior;

    private float limiteX;
    void Start()
    {
        // Define a posicao de retorno com base na posicao inicial
        limiteX = transform.position.x;
    }

    void Update () {

        if (FlappyBird.jogando)
        {
            // Mover o cano
            transform.Translate(Vector2.left * velocidade * Time.deltaTime);

            // Retorna na posicao inicial quando atingir o limite
            if (transform.position.x < -limiteX)
            {
                // Reposiciona o cano para o inicio
                transform.position = new Vector2(limiteX,
                    Random.Range(limiteInferior, limiteSuperior));
            }
        }


        

	}
}
