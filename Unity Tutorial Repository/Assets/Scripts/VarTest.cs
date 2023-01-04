using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarTest : MonoBehaviour
{
    // declare variables
    public int ValorIntPub = 10;
    private int ValorIntPriv;
    public float ValorFloat = 10.21f;
    int Valor; // declare as private
    public string Text = "Hello World";

    // unity variables
    public GameObject ObjetoJogo; // 
    public Transform TransformarUnity; //    

    // Start is called before the first frame update
    void Start()
    {
        ObjetoJogo = gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
