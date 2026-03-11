using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Splines;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Pontuation : MonoBehaviour
{
    public Rigidbody2D player;

    public TextMeshProUGUI textUi;

    public int valor1;

    public int valor2 = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        valor1 = (int)player.position.y;

        if(valor1 >= valor2)
        {
            valor2 = valor1;
        }

        textUi.text = valor2.ToString();
    }
}
