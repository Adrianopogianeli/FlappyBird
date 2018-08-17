using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour {

    public static bool jogando;
    
    // Atributos
    public float impulso;
    public AudioClip[] somClips;
    
    private bool impulsionar;
      

    // Componentes
    private Rigidbody2D rb2d;
    private AudioSource som;
   
    // Inicializacao
	void Start () {

        // Marca que o jogo nao iniciou
        jogando = false;
        
        // Referencia do componente
        rb2d = GetComponent<Rigidbody2D>();
        som = GetComponent<AudioSource>();

        // Remove a gravidade do jogador
        rb2d.gravityScale = 0.0f;
        
	}
		
    // Game Looping
	void Update () {
        

        if (!jogando && Input.GetButtonDown("Fire1"))
        {
            jogando = true;
            rb2d.gravityScale = 1.0f;
        }
        
        // Controle - Fire1 (CTRL esquerdo, Clique esquerdo ou Toque na tela)
        if (Input.GetButtonDown("Fire1"))
        {        

            Tocar(0);
            impulsionar = true;
        }


        // Rotacao da queda
        if (jogando)
        {            
            transform.eulerAngles = new Vector3(0.0f, 0.0f, 
                rb2d.velocity.y + 10.0f);
        }

    }

    // Instrucoes de fisica
    void FixedUpdate()
    {
        // Impulso
        if (impulsionar)
        {
            // Freia a velocidade em Y para poder aplicar o impulso
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0.0f);
            rb2d.AddForce(Vector2.up * impulso);

            impulsionar = false;
        }
    }

    // Registra a pontuacao
    void OnTriggerExit2D(Collider2D c)
    {
        Tocar(1);
        Placar.pontos++;
    }

    // Registra colisao
    void OnCollisionEnter2D(Collision2D c)
    {
        StartCoroutine(Fim(1.0f));
    }

    IEnumerator Fim(float t)
    {
        Tocar(2);
        yield return new WaitForSeconds(t);
        SceneManager.LoadScene("StartScene");
    }





    // Executa audio
    void Tocar(int i)
    {
        som.clip = somClips[i];
        som.Play();
    }


}
