using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTest : MonoBehaviour
{
    // https://alunos.crieseusjogos.com.br/51428-desenvolvimento-unity/1139160-manipulando-getcomponents-e-gameobjects
    public GameObject Objeto;
    // Start is called before the first frame update
    void Start()
    {
        Objeto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
