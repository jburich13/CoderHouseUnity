using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2 : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > 2)
        {
            MoverHaciaVin();
        } else Debug.Log("Esta muy cerca");
    }


    public void MoverHaciaVin()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
}
