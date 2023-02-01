using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRotateTest : MonoBehaviour
{
    public float Speed;
    public float Rotation;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.up * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0,0,1) * Rotation * Time.deltaTime);
        }

          if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0,0,-1) * Rotation * Time.deltaTime);
        }

    }
}
