using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // Libreria que sirve para cambiar entre escenas 

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Metodo que nos sirve para cuando pulsamos el boton Start
    public void StartButton()
    {
        GameManager.instance.ChangeScene("TestLevel");
    }
}
