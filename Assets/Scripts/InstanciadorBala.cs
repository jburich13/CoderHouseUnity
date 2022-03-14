using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorBala : MonoBehaviour
{
    [SerializeField] private GameObject bala;
    [SerializeField] private Transform spawner;
    [SerializeField] private ParticleSystem humo;
    [SerializeField] private ParticleSystem fuego;
    
    public void ReproducirEffectoCañon()
    {
        humo.Play();
        fuego.Play();
    }

    public void PausarEffectoCañon()
    {
        humo.Stop();
        fuego.Stop();
    }
    
    
    void InstanciarBalas(int cantBalas)
    {
        for (int i = 0; i<cantBalas;i++)
        {
            Instantiate(bala, spawner.position + new Vector3((i / 3.6f), 0, 0), Quaternion.identity);
            ReproducirEffectoCañon();
            Invoke("PausarEffectoCañon",1.0f);
            
        }
    }
    
    void Update()
    {
        if (Input.GetKeyDown("j"))
        {
           InstanciarBalas(2);
        }
        
        if (Input.GetKeyDown("k"))
        {
            InstanciarBalas(3);
        }
        
        if (Input.GetKeyDown("l"))
        {
            InstanciarBalas(4);
        }
    }
}
