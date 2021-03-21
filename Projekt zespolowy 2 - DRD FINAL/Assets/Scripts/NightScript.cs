using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightScript : MonoBehaviour
{
    public LightingManager manager;
    public GameObject Night;
    public GameObject Birds;
    public GameObject MaterialsSounds;
   public bool isNight = false;
    int i = 0;
    int a = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Night2();
        if(isNight)
        {
            Birds.SetActive(false);
            Night.SetActive(true);
            if(i == 0)
            {
                nightsounds();
                i++;
                a = 0;
            }
           

            
            Debug.Log("najs");
        }
        else
        {
            Night.SetActive(false);
            Birds.SetActive(true);
            if(a == 0)
            {
                daysound();
                a++;
                i = 0;
            }
        }
    }
    void Night2()
    {
        if (manager.TimeofDay >= 180f || manager.TimeofDay <= 60f)
        {
            MaterialsSounds.SetActive(false);
            isNight = true;
        }
        else
        {
            MaterialsSounds.SetActive(true);
            isNight = false;
        }
    }
    void nightsounds()
    {
        FindObjectOfType<AudioManager>().Play("Night");
    }
    void daysound()
    {

        FindObjectOfType<AudioManager>().Play("Animal");
    }
    
}
