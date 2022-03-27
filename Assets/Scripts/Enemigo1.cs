using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo1 : MonoBehaviour
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
        mirarAVin();
    }


    public void mirarAVin()
    {
        Quaternion lookRotation = Quaternion.LookRotation((target.transform.position - transform.position));
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, speed * Time.deltaTime);
    }


}
