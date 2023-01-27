using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceDestroyTest : MonoBehaviour
{
    public GameObject Prefab;
    public GameObject Pai;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Spawn by Position
            // Instantiate(Prefab, new Vector3(10,0,0), Quaternion.identity);

            // Spawn object by GameObject
            Instantiate(Prefab, Pai.transform.position, Quaternion.identity);
        }
        

    }
}
