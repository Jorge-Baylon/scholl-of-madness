using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    private float tiempo = 10f;
    public Text contadorText;

    // Start is called before the first frame update
    void Start()
    {
        contadorText.text = "  " + tiempo;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;

        contadorText.text = "  " + tiempo.ToString ("f0");
    }
}
