using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorBala : MonoBehaviour
{
    [SerializeField] private GameObject bala;
    [SerializeField] private Transform spawner;
    [SerializeField] private float tiempoParaInstanciar;
    private float tiemporRestante;
    void Start()
    {
        ResetTimer();
        
    }
    void Update()
    {
        Temporizador();
        AumentarTamaño();
    }

    void ResetTimer()
    {
        tiemporRestante = tiempoParaInstanciar;
    }

    void Temporizador()
    {
        tiemporRestante -= Time.deltaTime;
        if (tiemporRestante <= 0)
        {
            var instanciaBala = Instantiate(bala,spawner.position, Quaternion.identity);
            Destroy(instanciaBala,5f);
            ResetTimer();
            
        }
    }


    void AumentarTamaño()
    {
        if (Input.GetKeyDown("space"))
        {
            bala.transform.localScale += bala.transform.localScale * 2;
        }
    }
}
