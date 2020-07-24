using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public float tiempo= 10f;
    public Text contadorText;
    public int TiempoToText;
    public string escena;
    public GameObject Objeto;

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        TiempoToText = (int)tiempo;
        contadorText.text = TiempoToText.ToString();
        if(tiempo <= 0)
        {
            
        }
    }
}
