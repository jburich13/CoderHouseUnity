using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo3 : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speed;
    public enum Eleccion
    {
        moverteHaciaVin,
        MirarAVin
    }

    [SerializeField] private Eleccion eleccion;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (eleccion)
        {
            case Eleccion.moverteHaciaVin:
                if (Vector3.Distance(transform.position, target.transform.position) > 2)
                {
                    moverHaciaVin();
                } else Debug.Log("Esta muy cerca");
                break;
            case Eleccion.MirarAVin:
                mirarAVin();
                break;
            default:
                Debug.Log("Default");
                break;
        }
    }
    
    
    public void mirarAVin()
    {
        Quaternion lookRotation = Quaternion.LookRotation((target.transform.position - transform.position));
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, speed * Time.deltaTime);
    }
    
    public void moverHaciaVin()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
}
