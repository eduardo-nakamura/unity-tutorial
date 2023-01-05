using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileTest : MonoBehaviour
{
    //int item = 5;
    int dinheiro = 500;
    // Start is called before the first frame update
    void Start()
    {
        //while (item > 0)
        //{
        //    Debug.Log("While is " + item);
        //    item--;
        //}

        do
        {
            Debug.Log("Valor na Carteira: " + dinheiro);
            dinheiro += 100;
        } while (dinheiro < 1000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
