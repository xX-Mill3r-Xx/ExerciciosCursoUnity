using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio7 : MonoBehaviour
{
    /*
     Crie uma classe que represente um zumbi, todos seus atributos 
      devem ser públicos
     */
    [System.Serializable]
    public class Zumbi
    {
        public string nome;
        public float forca;
        public string habilidade;
    }

    public Zumbi z = new Zumbi();

    void Start()
    {
        Debug.Log(z.nome);
        Debug.Log(z.forca);
        Debug.Log(z.habilidade);
    }
}
