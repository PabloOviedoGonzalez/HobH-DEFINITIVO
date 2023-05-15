using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerXP : MonoBehaviour
{
    [SerializeField] private float Experience;
    [SerializeField] private float Maxexperience;
    [SerializeField] private XPbar xpbar;

    private void Start()
    {
        Maxexperience = 0;
        Experience = Maxexperience;
        xpbar.InicializeExperience(Experience);
    }
    private void Update()
    {
        xpbar.enemyPoints = Experience;
        Maxexperience = Experience;
        /*if (GameManager.instance.GetEnemyPoints() >= 1)
        {

            Experience = Experience *= 2;
        }
        if (GameManager.instance.GetEnemyPoints() >= GameManager.instance.IsPlayerLevelMax)
        {
            Debug.Log("HealthMax");
            Experience = Experience += 50;
        }
        */

    }

    public void GetExperiencePoints(float ExperiencePoints)
    {
        Experience -= ExperiencePoints;
        xpbar.ChangeExperience(Experience);
    }

    public float GetExperience()
    {
        return Experience;
    }

}
