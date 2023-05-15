using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public GameObject GameOver;
    [SerializeField] private float Health;
    [SerializeField] private float Maxhealth;
    //[SerializeField] private int healthofplayer;
    [SerializeField] private HealthBar healthbar;

    private void Start()
    {
        Health = Maxhealth;
        healthbar.InicializeHealth(Health);
    }
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

    public void GetDamage(float damage)
    {
        Health -= damage;
        healthbar.ChangeHealth(Health);

        if (Health <= 0)
        {
            Time.timeScale = 0f;
            GameOver.SetActive(true);

        }
    }

    public float GetHealth()
    {
        return Health;
    }

}
