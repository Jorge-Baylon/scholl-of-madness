using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nivel_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EmpezarJuego()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); 
    Debug.Log("funciona nivel 1");
}

    public void Salir()
{
    Application.Quit();
    Debug.Log("salir funciona");
}
}
