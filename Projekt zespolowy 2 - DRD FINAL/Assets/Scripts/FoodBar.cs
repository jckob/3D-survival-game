using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodBar : MonoBehaviour
{

    public Slider slider;
    public LightingManager manager;
    public float minusFood;
    public float lastTime;

    private void Start()
    {
        //manager = GetComponent<LightingManager>();
        //slider = GetComponent<Slider>();
        lastTime = manager.TimeofDay;

    }
    public void SetFood(float food)
    {
        slider.value = food;
    }
    public void Update()
    {
        if (manager.TimeofDay - lastTime > 5)
        {    
            SetFood(slider.value - minusFood);
            lastTime = manager.TimeofDay; 
        }
        if(Input.GetButtonDown("Apple") && slider.value <=80)
        {
            AppleCollect.theScore -= 1;
            SetFood(slider.value + 20);

            
        }
    }

}