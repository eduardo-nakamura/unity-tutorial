using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysTest : MonoBehaviour
{
    public GameObject[] Player;
    // string[] Inimigos = new string[3];
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject item in Player)
        {
            Debug.Log(item.name);
        }
        // for (int i = 0; i < Player.length; i++)
        // {
        //     Debug.Log("i");
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
