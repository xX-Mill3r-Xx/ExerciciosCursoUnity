using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio8 : MonoBehaviour
{
    /*
      Crie um objeto da classe zumbi e exiba no console cada atributo 
        criado.
     */
    [System.Serializable]
    public class Zumbi
    {
        public string nome;
    }

    public Zumbi z = new Zumbi();

    void Start()
    {
         Debug.Log($"O nome do Zumbi é {z.nome}");
    }
}
