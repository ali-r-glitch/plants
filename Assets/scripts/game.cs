using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    public float health, soil, temperature,ego,multiplier;
    public Slider slhealth, slsoil, sltemperatur, slego;
    // Start is called before the first frame update
    void Start()
    {
        slhealth.maxValue = 100;
        slsoil.maxValue = 100;
        sltemperatur.maxValue = 100;
        slego.maxValue = 100;


        health = 100;
        soil = 100;
        temperature = 50;
        ego = 100;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        health -= 1* multiplier;
        soil -= 1 * multiplier;

        if(temperature<=50)
        {
            temperature -= 1 * multiplier;
        }else
        {
            temperature += 1 * multiplier;
        }
        
        ego -= 1 * multiplier;

        /*
        slhealth.value = health;
        slsoil.value = soil;
        sltemperatur.value = temperature;
        slego.value = ego;*/
    }
}
