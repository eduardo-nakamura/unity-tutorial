using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    // public List<int> Valores = new List<int>();
    [System.Serializable]
    public class Inimigo
    {  
        public string nome;
        public int vida;
        public int velocidade;
        public int forca;

     
        public Inimigo(string Nome, int Vida, int Velocidade, int Forca)
        {
            nome = Nome;
            vida = Vida;
            velocidade = Velocidade;
            forca = Forca;
        }
    }

    public List<Inimigo> inimigos = new List<Inimigo>();

    // Start is called before the first frame update
    private void Start()
    {
        inimigos.Add(new Inimigo("Andore", 100, 20, 100));
        inimigos.Add(new Inimigo("TwoP", 40, 80, 60));
        StaticTest.statics.UpdateVidas(3);
        Debug.Log("Vidas: " + StaticTest.statics.Vidas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
