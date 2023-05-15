using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPbar : MonoBehaviour
{
  
    private Slider slider;


    private void Start()
    {
        slider = GetComponent<Slider>();
    }



    public void ChangeMaxexperience(float Maxexperience)
    {
        slider.maxValue = Maxexperience;
    }

    public void Changexperience(float experience)
    {
        slider.value = experience;
    }

    public void InicializeExperience(float Thexperience)
    {
        ChangeMaxexperience(Thexperience);
        Changexperience(Thexperience);
    }
}