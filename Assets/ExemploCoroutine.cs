using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExemploCoroutine : MonoBehaviour {

    int i;


	// Use this for initialization
	IEnumerator Start () {

        yield return new WaitForSeconds(5.0f);
        print("Inicio");

        yield return new WaitForSeconds(3.0f);
        i++;
        print(i);
        StartCoroutine(Start());
    }

}
