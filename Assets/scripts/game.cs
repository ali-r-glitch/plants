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
        //multiplier += 0.001f;
        if(ego>0f)
        {
         
            ego -= 0.1f * multiplier;
        }else
        {
            health -= 0.1f * multiplier;
        }
        if (ego>70f)
        {
            health++;
        }
        if (soil > 0f)
        {
            soil -= 0.1f * multiplier;
        }
    else
        {
            health -= 0.1f * multiplier;
        }

if (temperature<=50 && temperature>0)
        {
            temperature -= 0.1f * multiplier;
        }
if (temperature > 50 && temperature < 100)
        {
            temperature += 0.1f * multiplier;
        }
        
       

        
        slhealth.value = health;
        slsoil.value = soil;
        sltemperatur.value = temperature;
        slego.value = ego;
    }
}
