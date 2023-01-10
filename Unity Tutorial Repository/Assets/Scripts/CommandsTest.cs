using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandsTest : MonoBehaviour
{
    void OnMouseDown() {
        Debug.Log("Click!");
    }
    void OnMouseEnter() {
        Debug.Log("Selected");
    }
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Space Key Pressed");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A Key Pressed");
        }

        if (Input.GetKeyUp(KeyCode.B))
        {
            Debug.Log("B Key Pressed");
        }
    }
}
