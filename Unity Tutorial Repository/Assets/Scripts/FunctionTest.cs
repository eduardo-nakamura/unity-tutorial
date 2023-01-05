using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionTest : MonoBehaviour
{
    public int ValVida;    
    public int ValDano;
    // Start is called before the first frame update
    void Start()
    {
        AumentaVida(); 
        AumentaVida();
        AumentaVida();   
        Dano(ValDano);
        Debug.Log(ValVida);
    }

    // Update is called once per frame
    void Update() { }

    void AumentaVida()
    {
        ValVida += 10;
    }

    void Dano(int dano)
    {
        ValVida -= dano;
    }
}
