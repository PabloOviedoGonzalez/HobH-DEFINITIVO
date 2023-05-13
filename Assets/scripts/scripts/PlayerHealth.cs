using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    protected int Health= 30;
    //[SerializeField] private int healthofplayer;
    private void Update()
    {
        if (GameManager.instance.GetEnemyPoints() >= 1)
        {
            
            Health = Health *=2;
        }
        if (GameManager.instance.GetEnemyPoints() >= GameManager.instance.IsPlayerLevelMax)
        {
            Debug.Log("HealthMax");
            Health = Health += 50;
        }
        //if (GameManager.instance.GetEnemyPoints() >= 1)
        //{
        //    Health = GameManager.instance.Health *= 2;
        //}
    }

    public void GetDamage(int damage)
    {
        GameManager.instance.Health -= damage;

        if (GameManager.instance.Health <= 0)
        {
            SceneManager.LoadScene("GameOver");

        }
    }

    public float GetHealth()
    {
        return Health;
    }

}
