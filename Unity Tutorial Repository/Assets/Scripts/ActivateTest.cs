using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTest : MonoBehaviour
{
    
    public GameObject Objeto;
    // Start is called before the first frame update
    void Start()
    {
        // Deactivate Object
        // Objeto.SetActive(false); 

        // Deactivate Object using GetComponent
        // Objeto.GetComponent<SpriteRenderer>().enabled = false;

        // Check if Object is Active
        if (Objeto.activeSelf)
        {
            Objeto.SetActive(false);
        } else
        {
            Objeto.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
