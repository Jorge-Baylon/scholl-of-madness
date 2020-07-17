using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public text contador;
    private float tiempo = 10f;
    // Start is called before the first frame update
    void Start()
    {
        contador = "  " + tiempo;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= time.deltaTime;

        contador = "  " + tiempo.ToString ("f0");
    }
}
