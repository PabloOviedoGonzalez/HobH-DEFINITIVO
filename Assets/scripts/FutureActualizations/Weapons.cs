using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapons 
{
    private string name;
    protected int attackPower;


    public Weapons()
    {
         attackPower = 0;
    }


    public Weapons(string nameValue, int attackValue)
    {
        name = nameValue;
        
        attackPower = attackValue;
    }

    protected void Shot(float value)
    {
        Debug.Log("Ataco con una fuerza de " + value);
    }

    protected abstract void Attack(float value);
    
       
    









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
