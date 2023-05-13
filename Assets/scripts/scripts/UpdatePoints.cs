using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePoints : MonoBehaviour
{
    public TMPro.TMP_Text puntosText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        string v1 = "PUNTOS:  " + GameManager.instance.GetEnemyPoints();
        string v = v1;
        puntosText.text = v;
    }
}
