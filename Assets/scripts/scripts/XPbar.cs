using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPbar : MonoBehaviour
{
  
    private Slider slider;
    public float enemyPoints;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    private void update()
    {
        
    }

    public void AddEnemyPoints(float value)
    {
        enemyPoints += value;
    }

    public void ChangeMaxexperience(float Maxexperience)
    {
        slider.maxValue = Maxexperience;
    }

    public void ChangeExperience(float experience)
    {
        slider.value = experience;
    }

    public void InicializeExperience(float Thexperience)
    {
        ChangeMaxexperience(Thexperience);
        ChangeExperience(Thexperience);
    }
}