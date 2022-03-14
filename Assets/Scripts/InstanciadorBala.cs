using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorBala : MonoBehaviour
{
    [SerializeField] private GameObject bala;

    [SerializeField] private Transform spawner;
    void Start()
    {
        
        
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(bala, spawner.position, Quaternion.identity);
        }
    }
}
