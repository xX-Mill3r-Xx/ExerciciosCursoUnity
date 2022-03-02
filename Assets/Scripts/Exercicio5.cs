using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio5 : MonoBehaviour
{

    /*
      Crie um vetor para guardar 5 nomes de vilões, depois imprima no 
       console cada um dos nomes.
     */

    public string[] inimigos = new string[5];

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(inimigos[0]);
        Debug.Log(inimigos[1]);
        Debug.Log(inimigos[2]);
        Debug.Log(inimigos[3]);
        Debug.Log(inimigos[4]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
