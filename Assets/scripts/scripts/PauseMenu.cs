using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //[SerializeField] private GameObject botonpausa;
    [SerializeField] private GameObject menupausa;
   


  


     public void Update()
     {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            //botonpausa.SetActive(false);
            menupausa.SetActive(true);
        }

        
     }
   

    public void reanudar()
    {
        Time.timeScale = 1f;
        //botonpausa.SetActive(true);
        menupausa.SetActive(false);
    }
        
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