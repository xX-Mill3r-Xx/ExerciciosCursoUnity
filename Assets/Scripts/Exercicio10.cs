using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio10 : MonoBehaviour
{
    public class Zumbi
    {
        public int vida;
        public float velocidade;
        public float energia;

        public virtual void Atacar()
        {
            print("Pai atacando");
        }
    }

    public class Zumbi_Filho : Zumbi
    {
        public override void Atacar()

        {
            print("Filho atacando");
        }
    }

    void Start()
    {
        Zumbi pai = new Zumbi();
        Zumbi_Filho filho = new Zumbi_Filho();
        pai.Atacar();
        filho.Atacar();
    }

}
