using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

   
    private int punctuation = 0;//Para la puntuacion.
    private float time = 0;//Para el tiempo.
    private int enemyPoints;
    private int enemyKills = 0;
    public int IsPlayerLevelMax = 10;
    public float Health = 30;





    void Awake() // se hace en el awake para q se inicialice lo primero, por si en el start hubiera algo q lo use y lo usase antes de q se iniciase
    {
        if (instance == null)//comprueba si instance no contiene informacion. tambien hace q no se destruya nunca
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //si tiene info, significa q ya existe otro GameManager y destruye este para q no se duplique ya q solo puede haber uno
            Destroy(gameObject);
        }
    }






    public void ChangeScene(string name)
    {

        SceneManager.LoadScene(name);
        
    }

    public void AddPunt(int value)
    {
        punctuation += value;
    }

    public void AddEnemyPoints(int value)
    {
        enemyPoints += value;
    }

    public int GetPunt()
    {
        return punctuation;
    }
    public float GetTime()
    {
        return time;
    }

    public int GetEnemyPoints()
    {
        return enemyPoints;
    }

    public int GetenemyKills()
    {
        return enemyKills;
    }

    public void AddenemyKills(int value)
    {
        enemyKills += value;
    }

    //public void LevelUp(int value) 
    //{
    //    if (enemyPoints = 100)
    //    {

    //    }
    //}

    public void ExitTheGame(string Exit)
    {
        //AudioManager.instance.ClearAudioList();
        Debug.Log("has left the game.");
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
