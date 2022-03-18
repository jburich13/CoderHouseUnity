using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    [SerializeField] private GameObject cam1, cam2, cam3;
    void Update()
    {
        TransicionCamara();
    }


    void activarCamara(int numCamara)
    {
        if (numCamara == 1)
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
        } else if (numCamara == 2)
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
        } else if (numCamara == 3)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
        }

    }

    void TransicionCamara()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            activarCamara(1);
        } else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            activarCamara(2);
            
        } else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            activarCamara(3);
        }
    }
}
