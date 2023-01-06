using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticTest : MonoBehaviour
{
    // Olhar em ListTest    
    public static StaticTest statics;
    public int Vidas = 3;
    // Start is called before the first frame update
    void Start()
    {
        statics = this;    
    }

    
    public void UpdateVidas(int val)
    {
        Vidas += val;
        Debug.Log(Vidas);
    }
}
