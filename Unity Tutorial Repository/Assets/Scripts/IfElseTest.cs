using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseTest : MonoBehaviour
{
    public int n1 = 10;
    public int n2 = 9;

    public bool Valor;
    // Start is called before the first frame update
    void Start()
    {
        if (n1 > 0)
        {
            Debug.Log("N1 Positivo");
        } else if(n1 < 0) {
            Debug.Log("N1 Negativo");
        } else
        {
            Debug.Log("N1 igual a 0");
        }

        if (Valor)
        {
            Debug.Log("Verdadeiro");
        }
        else
        {
            Debug.Log("Falso");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
