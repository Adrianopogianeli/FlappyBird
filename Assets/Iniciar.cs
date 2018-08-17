using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Iniciar : MonoBehaviour {
      
	
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Entrar(0.5f));
        }
	}

    IEnumerator Entrar(float t)
    {
        yield return new WaitForSeconds(t);
        SceneManager.LoadScene("GameScene");
    }


}
