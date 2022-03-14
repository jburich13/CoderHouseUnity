using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaMovimiento : MonoBehaviour
{
    [SerializeField] private Vector3 direccion = new Vector3(0.01f, 0, 0);
    [SerializeField] private float velocidad = 0.1f;
    void Update()
    {
        transform.position -= direccion * velocidad * Time.deltaTime;
    }
}
