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
        SceneManager.LoadScene("TestLevel");
    }

    public void Salir()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
