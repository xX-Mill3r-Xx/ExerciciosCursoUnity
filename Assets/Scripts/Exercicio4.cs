using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio4 : MonoBehaviour
{
    /*. Crie um laço de qualquer tipo que seja capaz de 
     * imprimir no console números de 0 (zero) até 10.*/

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 11; i++)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
