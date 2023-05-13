using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] private Transform Controladordisparo;
    [SerializeField] private GameObject bala;

    float currentTime;
    private float maxTime = 1.3f;

    private void Update()
    {
        currentTime += Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && currentTime >= maxTime)
        {
            //Disparar
            Disparar();
            currentTime = 0;
        }
    }

    private void Disparar()
    {
        Instantiate(bala, Controladordisparo.position, Controladordisparo.rotation);
    }
}

