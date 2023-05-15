using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Slider slider;


    private void Start()
    {
        slider = GetComponent<Slider>();
    }



    public void ChangeMaxHealth(float MaxHealth)
    {
        slider.maxValue = MaxHealth;
    }

    public void ChangeHealth(float Health)
    {
        slider.value = Health;
    }

    public void InicializeHealth(float TheHealth)
    {
        ChangeMaxHealth(TheHealth);
        ChangeHealth(TheHealth);
    }
}
