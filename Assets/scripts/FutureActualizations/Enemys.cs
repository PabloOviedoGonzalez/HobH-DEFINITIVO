using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys
{
    private string name;
    protected int health, attackPower;



    public Enemys()
    {
        health = attackPower = 0;
    }




    public Enemys(string nameValue, int healthValue, int attackValue)
    {
        name = nameValue;
        health = healthValue;
        attackPower = attackValue;
    }



    protected void Attack(float value)
    {
        Debug.Log("Ataco con una fuerza de " + value);
    }



    public int GetHealth()
    {
        return health;
    }


    public void SetHealth(int value)
    {
        if (value >= 0)
            health = value;
    }


    public int GetattackPower()
    {
        return attackPower;
    }


    public void SetattackPower(int value)
    {
        if (value >= 0)
            attackPower = value;
    }


}
