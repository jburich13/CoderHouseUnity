using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorBala : MonoBehaviour
{
    [SerializeField] private GameObject bala;

    [SerializeField] private Transform Spawner;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(bala, Spawner);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
