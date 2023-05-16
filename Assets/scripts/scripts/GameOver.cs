using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public void reiniciar()
    {
        Time.timeScale = 1f;
        //GameManager.instance.time = 0;
        //GameManager.instance.puntuacion = 0;
        GameManager.instance.ChangeScene("TestLevel");
    }

    public void Salir()
    {
        GameManager.instance.ChangeScene("MainMenu");
    }

}
