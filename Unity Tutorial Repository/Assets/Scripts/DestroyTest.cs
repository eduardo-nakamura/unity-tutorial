using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Destrou after 2 seconds
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        // Destrou when Z is pressed
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Destroy(gameObject);
        }
    }
}
