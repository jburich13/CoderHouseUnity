using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaMovimiento : MonoBehaviour
{
    [SerializeField] private Vector3 direction = new Vector3(0.01f, 0, 0);

    [SerializeField] private float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= direction * speed * Time.deltaTime;
    }
}
