using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion : MonoBehaviour
{

    private Vector3 objetivo;
    private UnityEngine.Camera camara;
    // Start is called before the first frame update

    private void Start()
    {
        camara = UnityEngine.Camera.main;    
    }

    // Update is called once per frame
    private void Update()
    {
        objetivo = camara.ScreenToWorldPoint(Input.mousePosition);
        float anguloRadianes = Mathf.Atan2(objetivo.y - transform.position.y, objetivo.x - transform.position.x);
        float anguloGrados = (180 / Mathf.PI) * anguloRadianes - 90;
        transform.rotation = Quaternion.Euler(0, 0, anguloGrados);
    }
}