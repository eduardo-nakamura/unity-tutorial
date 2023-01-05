using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForTest : MonoBehaviour
{
    int NumInimigos = 3;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < NumInimigos; i++)
        {
            Debug.Log("Inimigos Restantes: " + NumInimigos--);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
