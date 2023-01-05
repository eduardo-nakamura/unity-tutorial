using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwitchTest : MonoBehaviour
{

    public int DiaSemana = 1;
    void Start()
    {
        switch(DiaSemana)
        {
            case 1:
                Debug.Log("Domingo");
                break;
            case 2:
                Debug.Log("Segunda");
                break;
            case 3:
                Debug.Log("Terça");
                break;
            case 4:
                Debug.Log("Quarta");
                break;
            case 5:
                Debug.Log("Quinta");
                break;
            case 6:
                Debug.Log("Sexta");
                break;
            case 7:
                Debug.Log("Sábado");
                break;
            default:
                Debug.Log("Sem Valor");
                break;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
