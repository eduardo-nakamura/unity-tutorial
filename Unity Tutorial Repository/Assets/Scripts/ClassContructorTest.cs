using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassContructorTest : MonoBehaviour
{
    
    // string[] Inimigos = new string[3];
    // Classe
    [System.Serializable]
    public class Inimigo
    {
        // Atributos
        public string nome;
        public int vida;
        public int velocidade;
        public int forca;

        // Construtor
        public Inimigo(string Nome, int Vida, int Velocidade, int Forca)
        {
            nome = Nome;
            vida = Vida;
            velocidade = Velocidade;
            forca = Forca;
        }
    }

    public Inimigo Dug = new Inimigo("Dug", 50, 60, 70);
    public Inimigo TwoP = new Inimigo("TwoP", 40, 80, 60);
    public Inimigo Andore = new Inimigo("Andore", 100, 20, 100);
  
    // Start is called before the first frame update
    void Start() { 
        Debug.Log("Nome:" + Dug.nome);
        Debug.Log("Nome:" + TwoP.nome);
        Debug.Log("Nome:" + Andore.nome);
    }

    // Update is called once per frame
    void Update() { }
}
