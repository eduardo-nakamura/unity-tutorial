using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachTest : MonoBehaviour
{
    string[] Inimigos = new string[3];
    // Start is called before the first frame update
    void Start()
    {
        Inimigos[0] = "Abobo";
        Inimigos[1] = "Goomba";
        Inimigos[2] = "Freeza";

        foreach (var item in Inimigos)
        {
            Debug.Log("This is " + item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
