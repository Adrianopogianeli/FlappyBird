using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Placar : MonoBehaviour {

    public static int pontos;
    public Text txtPontos;

	void Start () {
        // Reset da variavel
        pontos = 0; 		
	}
		
	void Update () {
        // Exibe a pontuacao no elemento text
        txtPontos.text = pontos.ToString();
	}
}
