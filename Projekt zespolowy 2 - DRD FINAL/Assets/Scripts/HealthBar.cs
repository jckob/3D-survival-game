using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    public LightingManager manager;
    public FoodBar foodbar;
    public float lastTime2;
    public float minushealth = 2f;


    private void Start()
    {
        lastTime2 = manager.TimeofDay;
    }
    public void SetHealth(float health)
    {
        slider.value = health;
    }
    public void Update()
    {
        if (foodbar.slider.value <= 0 && manager.TimeofDay - lastTime2 > 5f)
        {
            SetHealth(slider.value - minushealth);
            lastTime2 = manager.TimeofDay;
            
        }


    }
}
