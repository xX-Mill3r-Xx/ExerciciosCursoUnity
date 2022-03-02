using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    /*
        Faça uma soma usando os valores inteiros de duas variáveis (valor1 e 
        valor2), coloque o resultado em uma terceira variável (result) e exiba 
        no console seu resultado
     */

    public int val1;
    public int val2;
    private int result;

    // Start is called before the first frame update
    void Start()
    {
        result = val1 + val2;
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
