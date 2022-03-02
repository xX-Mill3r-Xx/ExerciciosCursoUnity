using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    /*
      Crie uma estrutura condicional que exibe a palavra Unity se, e 
            somente se a variável inteira (engine) for maior que 10.
     
     */

    public int engine;

    // Start is called before the first frame update
    void Start()
    {
        if(engine > 10)
        {
            Debug.Log("Unity");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
