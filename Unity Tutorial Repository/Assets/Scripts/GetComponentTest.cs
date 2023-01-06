using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentTest : MonoBehaviour
{
    public Rigidbody rig;
    public BoxCollider box;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        box = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

