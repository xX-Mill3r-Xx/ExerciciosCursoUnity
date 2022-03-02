using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio9 : MonoBehaviour
{
    /*
      Crie uma classe chamada zumbi_filho e faça com que ela herde da 
       classe zumbi.
     */

    public class Zumbi
    {
        public int vida;
        public float velocidade;
        public float energia;
    }

    public class Zumbi_Filho : Zumbi
    {
        public string poder;
    }

    void Start()
    {
        
    }

}
