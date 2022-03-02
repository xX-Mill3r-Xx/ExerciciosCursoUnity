using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio6 : MonoBehaviour
{
    /* Crie uma lista contendo 10 elementos de qualquer tipo depois 
        imprima cada elemento no console.*/

    List<int> lista = new List<int>();

    void Start()
    {
        lista.Add(1);
        lista.Add(10);
        lista.Add(30);
        foreach (int listaVal in lista)
        {
            print(listaVal);
        }
    }
}
