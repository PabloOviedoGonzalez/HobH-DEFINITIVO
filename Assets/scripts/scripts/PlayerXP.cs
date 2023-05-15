using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerXP : MonoBehaviour
{



    public GameObject GameOver;
    [SerializeField] private float Experience;
    [SerializeField] private float Maxexperience;
    [SerializeField] private XPbar xpbar;

    private void Start()
    {
        Experience = Maxexperience;
        xpbar.InicializeExperience(Experience);
    }
    private void Update()
    {
        if (GameManager.instance.GetEnemyPoints() >= 1)
        {

            Experience = Experience *= 2;
        }
        if (GameManager.instance.GetEnemyPoints() >= GameManager.instance.IsPlayerLevelMax)
        {
            Debug.Log("HealthMax");
            Experience = Experience += 50;
        }


    }
}
