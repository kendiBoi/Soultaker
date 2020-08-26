using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider slider;
    
    public void SetMaxHealth(int MaxHealth)
    {
        slider.maxValue = MaxHealth;
        slider.value = MaxHealth;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }

   
}
