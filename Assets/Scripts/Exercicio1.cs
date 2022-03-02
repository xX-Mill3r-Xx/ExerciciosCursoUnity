using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio1 : MonoBehaviour
{

    /* 
      Crie variáveis para representar os seguintes itens:
       a. Número de vidas
       b. Número de moedas
       c. Nome
       d. Energia
     */

    public string nome;
    public int numeroVidas;
    public float numeroMoedas;
    public float energia;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"O nome do personagem é {nome}!");
        Debug.Log($"Este personagem tem uma quantidade total de {numeroVidas} vidas!");
        Debug.Log($"Este personagem tem uma quantidade total de {numeroMoedas} moedas!");
        Debug.Log($"Este personagem possui {energia} de energia!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
