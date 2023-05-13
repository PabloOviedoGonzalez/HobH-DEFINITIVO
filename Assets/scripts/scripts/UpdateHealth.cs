using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateHealth : PlayerHealth
{
    public TMPro.TMP_Text HealthText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string v = "HEALTH:  " + GetHealth();
        HealthText.text = v;
    }
}
